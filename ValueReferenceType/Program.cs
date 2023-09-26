using Lib;

namespace ValueReferenceType
{
    struct MyStruct
    {
        public string Name { get; set; }
    }

    class Run
    {
        public static void Main()
        {
            var str = "hello";
            var str2 = "hello";
            var str3 = Constants.Hello;
            var num = 1;

            object num2 = num;

            var st = new MyStruct() { Name = str};
            object st2 = str;

            Console.WriteLine(str.GetAddress());
            Console.WriteLine(str2.GetAddress());
            Console.WriteLine(str3.GetAddress());

            Console.WriteLine(num.GetAddress());
            Console.WriteLine(num.GetAddress());
            Console.WriteLine(AdressHelper.GetAddress(ref num2));
            Console.WriteLine(AdressHelper.GetAddress(ref num2));
            
            Console.WriteLine("---------------");
            
            Console.WriteLine(st.GetAddress());
            Console.WriteLine(AdressHelper.GetAddress(ref st2));
            Console.WriteLine(AdressHelper.GetAddress(ref st2));
            Console.WriteLine(AdressHelper.GetAddress(ref st2));
            
            Console.WriteLine(st.Name.GetAddress());
        }
    }
}