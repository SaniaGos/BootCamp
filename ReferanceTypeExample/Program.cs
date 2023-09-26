using System.Reflection;
using System.Runtime.InteropServices;

namespace ReferanceTypeExample
{
    internal class Program
    {

        public static class MemoryAddress
        {
            public static unsafe string Get(object a)
            {
                TypedReference tr = __makeref(a);
                IntPtr pointer = **(IntPtr**)(&tr);
                return "0x" + pointer.ToString("X");
            }

            private static object mutualObject;
            private static ObjectReinterpreter reinterpreter;

            static MemoryAddress()
            {
                MemoryAddress.mutualObject = new object();
                MemoryAddress.reinterpreter = new ObjectReinterpreter();
                MemoryAddress.reinterpreter.AsObject = new ObjectWrapper();
            }

            public static IntPtr GetAddress(object obj)
            {
                lock (MemoryAddress.mutualObject)
                {
                    MemoryAddress.reinterpreter.AsObject.Object = obj;
                    IntPtr address = MemoryAddress.reinterpreter.AsIntPtr.Value;
                    MemoryAddress.reinterpreter.AsObject.Object = null;
                    return address;
                }
            }

            public static T GetInstance<T>(IntPtr address)
            {
                lock (MemoryAddress.mutualObject)
                {
                    MemoryAddress.reinterpreter.AsIntPtr.Value = address;
                    T obj = (T)MemoryAddress.reinterpreter.AsObject.Object;
                    MemoryAddress.reinterpreter.AsObject.Object = null;
                    return obj;
                }
            }

            // I bet you thought C# was type-safe.
            [StructLayout(LayoutKind.Explicit)]
            private struct ObjectReinterpreter
            {
                [FieldOffset(0)] public ObjectWrapper AsObject;
                [FieldOffset(0)] public IntPtrWrapper AsIntPtr;
            }

            private class ObjectWrapper
            {
                public object Object;
            }

            private class IntPtrWrapper
            {
                public IntPtr Value;
            }
        }
        public class Car
        {
            public string Color;
            public Car(string color)
            {
                Color = color;
            }
        }

        struct MyStruct
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            var color = "blue";
            var obj1 = new Car("blue");
            var obj2 = obj1;
            var a = 5;

            Console.WriteLine(MemoryAddress.Get(obj1));
            Console.WriteLine(MemoryAddress.Get(obj2));
            Console.WriteLine(MemoryAddress.Get(a));

            a = 7;
            Console.WriteLine(MemoryAddress.Get(a));
            Console.WriteLine(MemoryAddress.Get(obj1.Color));
            Console.WriteLine(MemoryAddress.Get(color));
            Console.WriteLine("0x" + MemoryAddress.GetAddress(color).ToString("X"));

            
            var s = new MyStruct(){Age = 10, Name = color};

            Console.WriteLine("\nTest struct");
            Console.WriteLine(MemoryAddress.Get(s));
            Console.WriteLine(MemoryAddress.Get(s.Name));
            Console.WriteLine(MemoryAddress.Get(s.Age));
            s.Age = 15;
            s.Name = "ddd";
            Console.WriteLine("---------------");
            Console.WriteLine(MemoryAddress.Get(s));
            Console.WriteLine("0x" + MemoryAddress.GetAddress(s).ToString("X"));
            Console.WriteLine(MemoryAddress.Get(s.Name));
            Console.WriteLine(MemoryAddress.Get(color));
            Console.WriteLine("0x" + MemoryAddress.GetAddress(s.Name).ToString("X"));
            Console.WriteLine(MemoryAddress.Get(s.Age));
            Console.WriteLine("0x" + MemoryAddress.GetAddress(s.Age).ToString("X"));

        }
    }
}