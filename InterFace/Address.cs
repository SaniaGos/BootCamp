using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    internal class Address : IAddress
    {
        public string Street { get; set; }
        public string Index { get; set; }
    }
}
