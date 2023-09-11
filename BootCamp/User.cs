using LibCamp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp
{
    public abstract class User : IUser
    {
        public User(string userName)
        {
            ExternalId = string.Empty;
            Username = userName;
        }

        public static string GetRole()
        {
            return "User";
        }

        public Guid Id { get; set; }

        private string _name;
        protected string _sName;

        public string FullName
        {
            get 
            {
                return $"{_name} {_sName}";
            }
            set
            {
                if (value.Contains("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    _name = value.Replace("Admin", string.Empty, StringComparison.OrdinalIgnoreCase);
                }
            }
        }
        public int Age { get; set; }

        public string ExternalId { get; set; }
        public string Username { get; set; }
        public string SName { get; set; }

        public abstract void Foo();

        public virtual void Foo2()
        {
            Console.WriteLine("I am user!");
        }
    }
}
