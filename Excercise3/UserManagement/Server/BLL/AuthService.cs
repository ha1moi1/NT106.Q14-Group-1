using Server.DAL;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Server.BLL
{
    internal class AuthService
    {

        private readonly UserRepository _repo;

        public AuthService()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserManagement"].ConnectionString;
            _repo = new UserRepository(connectionString);
        }


        public bool CheckInforSignIn(string username, string password)
        {
            var user = _repo.GetUserByUsername(username);
            if (user == null)
                return false;

            return user.Password == password;
        }



        public bool CheckSignUp(string username, string password, string email)
        {


            if (_repo.Exists(username))
                return false;
           

            if (_repo.EmailExists(email))
                return false;


            return true;
        }


        public bool Register(string username, string passwordHash, string email, string? fullName = null, DateTime? birthday = null)
        {


            if (!CheckSignUp(username, passwordHash, email))
            { return false; }

            var user = new User
            {
                Username = username,
                Password = passwordHash, 
                Email = email,
                FullName = fullName,
                BirthDay = birthday
            };

            _repo.AddUser(user);
            return true;
        }


    }
}
