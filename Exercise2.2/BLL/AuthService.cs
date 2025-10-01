using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Monopoly.DAL;
using Monopoly.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;

namespace Monopoly.BLL
{
    public class AuthService
    {
        private PlayerRepository _playerRepo;

        public AuthService()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ACCOUNT"].ConnectionString;
            _playerRepo = new PlayerRepository(connectionString);
        }

        public bool SignUp(string username, string password)
        {
            if (_playerRepo.GetPlayerByUsername(username) != null)
                return false;

            var player = new Player
            {
                UserName = username,
                Password = password 
            };
            _playerRepo.AddPlayer(player);
            return true;
        }
        public static string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = sha256.ComputeHash(bytes);

            StringBuilder builder = new StringBuilder();
            foreach (var b in hashBytes)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }
    }

        public bool SignUp(string username, string password, string email)
        {
            if (_playerRepo.GetPlayerByUsername(username) != null)
                return false;

            string hashedPassword = HashPassword(password);

            var player = new Player
            {
                UserName = username,
                Password = hashedPassword
            };
            _playerRepo.AddPlayer(player);
            return true;
        }

        public bool SignIn(string username, string password)
        {
            var user = _playerRepo.GetPlayerByUsername(username);
            if (user == null) return false;

            return user.Password == password;
        }

        public bool ValidateSignUp(string username, string password, string confirmPassword, string email, out string errorMessage)
        {
            errorMessage = null;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) || string.IsNullOrWhiteSpace(email))
            {
                errorMessage = "Vui lòng điền vào tất cả thông tin bắt buộc.";
                return false;
            }

            if (username.Length < 3)
            {
                errorMessage = "Tên người dùng phải có ít nhất 3 kí tự.";
                return false;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorMessage = "Địa chỉ email không hợp lệ.";
                return false;
            }

            if (password.Length < 6)
            {
                errorMessage = "Mật khẩu phải có ít nhất 6 kí tự.";
                return false;
            }

            if (password != confirmPassword)
            {
                errorMessage = "Mật khẩu không khớp.";
                return false;
            }

            if (_playerRepo.Exists(username))
            {
                errorMessage = "Tên người dùng đã tồn tại.";
                return false;
            }

            return true;
        }
    }
}
