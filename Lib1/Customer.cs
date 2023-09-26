using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib1
{
    public class Customer : User
    {
        public string CustomerId { get; set; }
        private string Phone { get; set; }

        public override string GetAddress()
        {
            return $"{City}, {Street}";
        }
    }
}
