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

    public override void FoovVirtual2()
    {
        base.FoovVirtual2();
        Console.WriteLine("I am admin!");
    }

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
        var admin = new Admin();

        //(admin as User).FoovVirtual2();
        //(admin as Admin).FoovVirtual2();

        //var tree = new ChristmasTree(3, 51);
        //tree.Draw();


        char[,] tree = new char[,] 
        { 
            { ' ', ' ',' ', ' ','*',' ', ' ',' ', ' ' },
            { ' ', ' ',' ', '*','*','*', ' ',' ', ' ' },
            { ' ', ' ','*', '*','*','*', '*',' ', ' ' },
            { ' ', '*','*', '*','*','*', '*','*', ' ' },
            { '*', '*','*', '*','*','*', '*','*', '*' },
        };

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write(tree[i,j]);
            }
            Console.WriteLine();
        }






        admin.FirstName = "Oleksandr";
        admin.SecondName = "Hutsenko";


        Console.WriteLine(admin.GetFullName());

        admin.SetFullName(new KeyValuePair<string, string>("Shyrik", "Sidorov"));
        Console.WriteLine(admin.GetFullName());
    }

    private static void PrintUser(IUser user)
    {
        var a = user as Admin;


        //Console.WriteLine("Admin");



        //Console.WriteLine($"User id {user.Id}, name {user.Name}, age {user.Age}");


    }

    private void Diamond(int height)
    {
        int startPosX = 50;
        int startPosY = 5;

        int maxX = 0;
        int startX = 0;
        var diff = 0;

        for (int y = 0; y < height; y++)
        {

            if (y < height / 2)
            {
                maxX = y * 2 - 1;
                for (int x = 0; x < maxX; x++)
                {
                    startX = startPosX + x - y;

                    Console.SetCursorPosition(startX, y + startPosY);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("*");
                }
            }
            else
            {
                var maxXd = 2 * (maxX - y) + 1;

                for (int x = 0; x < maxXd; x++)
                {
                    startX = startPosX + x - maxX + y - 1;

                    Console.SetCursorPosition(startX, y + startPosY);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("*");
                }
                diff++;
            }

        }

    }

}