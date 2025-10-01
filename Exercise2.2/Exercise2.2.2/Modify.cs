using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace Monopoly
{
    internal class Modify
    {
        public Modify() { }

        public List<Account> GetAllAccount()
        {
            List<Account> accounts = new List<Account>();
            using (var connection = Connection.GetConnection())
            {
                connection.Open();
                var query = "SELECT * FROM Account";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var username = reader["Username"].ToString();
                            var password = reader["Password"].ToString();
                            accounts.Add(new Account(username, password));
                        }
                    }
                }
                connection.Close();
            }
            return accounts;
        }


        public bool CheckUsernameExists(string username)
        {
            using (var connection = Connection.GetConnection())
            {
                connection.Open();
                var query = "SELECT COUNT(*) FROM Account WHERE Username = @Username";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    int count = (int)command.ExecuteScalar();
                    connection.Close();
                    return count > 0;
                }
            }
        }


        public bool RegisterAccount(string username, string email, string password)
        {
            try
            {
                using (var connection = Connection.GetConnection())
                {
                    connection.Open();
                    var query = "INSERT INTO Account (Username, Email, Password) VALUES (@Username, @Email, @Password)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        return rowsAffected > 0; // Trả về true nếu insert thành công
                    }
                }
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }

        public bool CheckLogin(string username, string password)
        {
            List<Account> accounts = GetAllAccount();

            foreach (Account account in accounts)
            {
                if (account.Username == username && account.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
