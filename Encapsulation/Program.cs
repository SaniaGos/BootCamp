using BabyAge;
using System.Net.Mail;

namespace Encapsulation
{
    internal class Adress
    {
        public string Town { get; set; }
        public string Street { get; set; }
    }

    internal class UserData
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public Pressure[] Pressures { get; set; }
    }

    internal class Pressure
    {
        public string Blood { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"Blood {Blood}, Create Date {Date.ToString("dd-MM-yyyy")}";
        }
    }

    internal class User
    {
        private readonly string _nickName;

        public Guid Id { get; set; }
        public MailAddress Email { get; set; }
        public Adress Adress { get; set; }
        public UserData UserData { get; set; }

        public User()
        {
            
        }
        public User(string nickName)
        {
            _nickName = nickName;
        }

        public override string ToString()
        {
            return $"NickName {_nickName}";
        }
    }

    class RunEncapsulation
    {
        static void Main2(string[] args)
        {
            User user = new User("Vasuliok")
            {
                Id = Guid.NewGuid(),
                Email = new MailAddress("vasul@as.com"),
                Adress = new Adress()
                {
                    Street = "Saliznuchna",
                    Town = "Franuk"
                },
                UserData = new UserData()
                {
                    Name = "Oleksandr",
                    Age = 38,
                    Password = "12345",
                    Pressures = new Pressure[]
                    {
                        new Pressure(){ Blood = "130/90", Date = DateTime.Now.AddDays(-7) },
                        new Pressure(){ Blood = "135/80", Date = DateTime.Now }
                    }
                }
            };

            var d1 = DateTime.Now;
            var d2 = DateTime.Now.AddMonths(-6);


            var d3 = d1 - d2;

            

            Console.WriteLine(user);


        }

        static void Main(string[] args)
        {
            var baby = new Baby(30,5,2010);
            var baby2 = new Baby("30-5-2010");

            baby.PrintAge();
            baby2.PrintAge();

            Console.WriteLine();
        }
    }
}
