using InterFace;

namespace InterfaceTest
{
    class Run
    {
        public static void Main()
        {
            var user = new User() { Email = "sasa@gmail.com", Password = "12345"};

            Console.WriteLine(((IUser)user).Login);

            user.Foo();
        }
    }
}
