using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Monopoly.Models;


namespace Monopoly.DAL
{
    public class PlayerRepository
    {
        public string _connectionString;

        public PlayerRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        //Phục vụ đăng nhập
        public Player GetPlayerByUsername(string username)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "SELECT USERID, USERNAME, PASSWORD, EMAIL FROM Player WHERE Username=@username", conn);
                cmd.Parameters.AddWithValue("@username", username);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Player
                        {
                            UserID = (int)reader["USERID"],
                            UserName = reader["USERNAME"].ToString(),
                            Password = reader["PASSWORD"].ToString(),
                            Email = reader["EMAIL"].ToString()
                        };
                    }
                }
            }
            return null;
        }
        public bool EmailExists(string email)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM Player WHERE EMAIL = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                conn.Open();

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }


        public void AddPlayer(Player player)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "INSERT INTO Player (USERNAME, PASSWORD, EMAIL) VALUES (@username, @password, @email)", conn);
                cmd.Parameters.AddWithValue("@username", player.UserName);
                cmd.Parameters.AddWithValue("@password", player.Password);
                cmd.Parameters.AddWithValue("@email", player.Email);
                cmd.ExecuteNonQuery();
            }
        }


        public bool Exists(string username)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM Player WHERE USERNAME = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

    }
}
