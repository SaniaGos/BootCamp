
namespace InheritanceTest
{
    interface  IFoo
    {
        void Foo2();
    }

    public abstract class A : IFoo
    {
        public virtual void Foo()
        {
            Console.WriteLine("Class A Foo");
        }

        public void Foo2()
        {
            Console.WriteLine("Class A Foo2");
        }
    }

    internal class B : A
    {
        public override void Foo()
        {
            Console.WriteLine("Class B Foo");
        }
    }

    class C : B, IFoo
    {
        public sealed override void Foo()
        {
            Console.WriteLine("Class C Foo");
            base.Foo();
        }

        public void Foo(int a)
        {
            Console.WriteLine("Class C Foo");
            base.Foo();
        }

        public new void Foo2()
        {
            Console.WriteLine("Class C Foo2");
        }
    }

    class Run
    {
        public static void Main()
        {
            IFoo a = new C();

            ((IFoo)((A)a)).Foo2();
            
        }
    }
}