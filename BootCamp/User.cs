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
            FirstName = userName;
        }

        public static string GetRole()
        {
            return "User";
        }

        public Guid Id { get; set; }

        private string _name;
        protected string _sName;

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {SecondName}";
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    var arr = value.Split(' ', ',', '-');
                    if (arr.Length == 2)
                    {
                        FirstName = arr[0];
                        SecondName = arr[1];
                    }
                }
            }
        }

        public string GetFullName()
        {
            return $"{FirstName} {SecondName}";
        }

        public void SetFullName(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var arr = value.Split(' ', ',', '-');
                if (arr.Length == 2)
                {
                    FirstName = arr[0];
                    SecondName = arr[1];
                }
            }
        }

        public void SetFullName(KeyValuePair<string, string> value)
        {
            if (!string.IsNullOrEmpty(value.Value) && !string.IsNullOrEmpty(value.Key))
            {
                FirstName = value.Key;
                SecondName = value.Value;
            }
        }

        public int Age { get; set; }

        public string ExternalId { get; set; }

        public abstract void Foo();

        public virtual void FoovVirtual2()
        {
            Console.WriteLine("I am user!");
        }
    }
}
