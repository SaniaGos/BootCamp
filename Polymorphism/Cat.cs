using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Cat : AnimalBase, IAnimal
    {
        public static string Description { get; set; }
        public const string Description2 = "";

        public override string GetVoice()
        {
            return "Meov";
        }

        public new virtual void GetPaw()
        {
            Console.WriteLine("Myrr");
            
        }

        public void GetVoice(uint count)
        {
            GetVoice(count, isToRepeat: true);
        }

        public void GetVoice(uint count, string name = "Pyshok", string sname = "", bool isToRepeat = true)
        {
            if (isToRepeat)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(GetVoice());
                }
            }
            else
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

    public class BigCat : Cat
    {
        public override void GetPaw()
        {
            Console.WriteLine("Ssssss");
        }
    }
}
