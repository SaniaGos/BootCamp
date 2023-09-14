using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }

        public string GetVoice()
        {
            return "Howl";
        }

        public string GetColor()
        {
            return "Black";
        }

        public string GetColor(string animalName)
        {
            return $"Dog {animalName} is {GetColor()}!";
        }
    }
}