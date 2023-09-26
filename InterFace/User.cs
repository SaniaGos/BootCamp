using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    internal class User : IUser, IUser_V2
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Address Address { get; set; }
        public List<string> OrderIds { get; set; }

        IEnumerable<string> IUser.OrderIds { get { return OrderIds; } set { OrderIds = value.ToList(); } }

        IAddress IUser.Address
        {
            get
            {
                return Address;
            }
            set
            {
                Address = new Address()
                {
                    Index = value.Index,
                    Street = value.Street
                };
            }
        }




        string IUser.Login
        {
            get
            {
                return string.IsNullOrEmpty(Name) ? Email : Name;
            }
        }

        string IUser_V2.Login
        {
            get;
        }

        public User() { }

        public void Foo()
        {
            Console.WriteLine((this as IUser).Login);
        }
    }
}
