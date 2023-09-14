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

        public string GetColor()
        {
            return "White";
        }
        public string GetColor(string animalName)
        {
            return $"Cat {animalName} is { GetColor() }!";
        }
    }
}
