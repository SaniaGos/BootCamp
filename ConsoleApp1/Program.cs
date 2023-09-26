namespace ConsoleApp1
{
    /*namespace NetLS_Camp
    {*/
        public abstract class UserBase
        {
            public string Name { get; set; }
            public virtual void Foo()
            {
                Console.WriteLine("UserBase");
            }
        }

        public class Admin : UserBase
        {
            public void Foo()
            {
                Console.WriteLine("Admin");
            }
        }

        class UserRun
        {
            static void Main(string[] args)
            {
                UserBase user = new Admin();
                user.Foo();
            }
        }
    /*}*/
}