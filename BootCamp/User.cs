using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp
{
    public abstract class User
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

        public int Id { get; set; }

        public string ExternalId { get; set; }

        public string Username { get; set; }

        public abstract void Foo();

        public virtual void Foo2()
        {
            Console.WriteLine("I am user!");
        }
    }
}
