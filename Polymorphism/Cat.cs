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

        public void GetVoice(uint count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(GetVoice());
            }
        }

        public void GetVoice(string addComand)
        {
            Console.WriteLine((string.IsNullOrEmpty(addComand) ? string.Empty : addComand + " ") + GetVoice());
        }



        public void GoPlay()
        {
            throw new NotImplementedException();
        }
    }
}
