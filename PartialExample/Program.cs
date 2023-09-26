using System.Collections;

namespace PartialExample
{

    public abstract partial class class1Partial : IEnumerable
    {
        public string name = "Vasyl";

        public abstract IEnumerator GetEnumerator();
    }
    
    public  partial class class1Partial
    {
        public static string surname = "Hrinyuk";

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}