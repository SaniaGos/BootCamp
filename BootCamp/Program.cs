using BootCamp;
using LibCamp;
using System.ComponentModel.DataAnnotations;

public class People
{
    [Range(100, 200)]
    public int UserId { get; set; }
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

public sealed class SuperAdmin : User
{
    private readonly string description;

    public SuperAdmin(string userName) : base("")
    {
        _sName = "Super";
    }

    public override void Foo()
    {
        
    }
}

public abstract class Parent
{
    public virtual void MyMethod()
    {
        Console.Write("parent");
    }
}

public class Child : Parent
{
    public override void MyMethod()
    {
        Console.Write("child");
    }
}


class Run
{
    public static void Main()
    {
        try
        {

        }
        catch (Exception ex)
        {

        }        


        Child child = new Child();
        (child as Parent).MyMethod();

        Console.ReadLine();
    }

    private static void PrintUser(IUser user)
    {
        var a = user as Admin;


        //Console.WriteLine("Admin");

        

        //Console.WriteLine($"User id {user.Id}, name {user.Name}, age {user.Age}");


    }

}