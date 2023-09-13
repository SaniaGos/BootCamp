using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public string GetVoice()
        {
            return "Meov";
        }
    }
}
