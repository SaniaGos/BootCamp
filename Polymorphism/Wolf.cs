using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Wolf : IAnimal
    {
        public string Name { get; set; }

        public string GetVoice()
        {
            return "Grrr!";
        }

        public string GetColor()
        {
            return "Grey";
        }

        public string GetColor(string animalName)
        {
            return $"Wolf {animalName} is {GetColor()}!";
        }
    }
}
