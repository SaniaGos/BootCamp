using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class MyConsole
    {
        public void WriteLine()
        {
            WriteLine(string.Empty);
        }

        public void WriteLine(int num)
        {
            WriteLine(num.ToString());
        }

        public void WriteLine(bool b)
        {
            if (b)
            {
                WriteLine(bool.TrueString);
            }
            else
            {
                WriteLine(bool.FalseString);
            }
        }

        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }
    }
}
