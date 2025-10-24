using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Models
{
    public class Users
    {
        public string? Id { get; private set; }
        public string? UserName { get; private set; }
        public string? Password { get; private set; }
        public string? Email { get; private set; }
        public string? FullName { get; private set; }
        public DateTime? Birthday { get; private set; }

        public Users()
        {
            Id = Guid.NewGuid().ToString();
            UserName = "nva";
            Password = "";
            Email = "xxx@gmail.com";
            FullName = "";
            Birthday = DateTime.Now;
        }
    }
}
