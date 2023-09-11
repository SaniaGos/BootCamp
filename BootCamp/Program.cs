using BootCamp;


public class People
{
    public int Id { get; set; }
}

public class Admin : User
{
    public Admin() : base("Vasul")
    {

    }

    public new void Foo2()
    {
        Console.WriteLine("I am admin!");
    }

    public override void Foo()
    {
        Console.WriteLine();
    }
}

public sealed class SuperAdmin : Admin
{

}

class Run
{
    public static void Main()
    {
        var role = User.GetRole();
        
        Console.WriteLine(role);
    }

}