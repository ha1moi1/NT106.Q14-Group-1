using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Server.DAL
{
    public class UserRepository
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }


        public Models.User? GetUserByUsername(string username)
        {
            const string sql = @"SELECT UserId, Username, Password, Email, FullName, Birthday
                                 FROM Users
                                 WHERE Username = @username";

            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@username", username);

            conn.Open();
            using var reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;

            var p = new Models.User
            {
                UserId = reader.GetInt32(reader.GetOrdinal("UserId")),
                Username = reader["Username"]?.ToString() ?? "",
                Password = reader["Password"]?.ToString() ?? "",
                Email = reader["Email"]?.ToString() ?? ""
            };

         

            return p;
        }

        public bool EmailExists(string email)
        {
            const string sql = @"SELECT COUNT(*) FROM Users WHERE Email = @email";

            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@email", email);

            conn.Open();
            int count = (int)cmd.ExecuteScalar()!;
            return count > 0;
        }



        public void AddUser(Models.User User)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(@"INSERT INTO Users (Username, Password, Email, FullName, Birthday)
                                 VALUES (@username, @password, @email, @fullname, @birthday);", conn);

                cmd.Parameters.AddWithValue("@username", User.Username);
                cmd.Parameters.AddWithValue("@password", User.Password);
                cmd.Parameters.AddWithValue("@email", User.Email);
                cmd.Parameters.AddWithValue("@fullname", User.FullName ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@birthday", User.BirthDay ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public bool Exists(string username)
        {
            const string sql = @"SELECT COUNT(*) FROM Users WHERE Username = @username";

            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@username", username);

            conn.Open();
            int count = (int)cmd.ExecuteScalar()!;
            return count > 0;
        }
    }
}
