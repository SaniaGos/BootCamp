using BootCamp;
using LibCamp;

public class People
{

    protected int UserId { get; set; }
}

public class Admin : User
{
    private int _age;
    public Admin() : base("Vasul")
    {

    }

    //public new void Foo2()
    //{
    //    Console.WriteLine("I am admin! " + _age);
    //}

    public override void Foo()
    {
        Console.WriteLine();
    }
}

public class SuperAdmin : User
{
    public SuperAdmin(string userName) : base("")
    {
    }

    public override void Foo()
    {
        throw new NotImplementedException();
    }
}

class Run
{
    public static void Main()
    {
        var user = new SuperAdmin("Sania");
        user.Id = Guid.NewGuid();
        user.Name = "Sania";
        user.Age = 33;

        PrintUser(user);
    }

    private static void PrintUser(IUser user)
    {
        var a = user as Admin;

        Console.WriteLine("Admin");



        //Console.WriteLine($"User id {user.Id}, name {user.Name}, age {user.Age}");


    }

}