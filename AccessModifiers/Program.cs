using Lib1;
using Lib2;
using Microsoft.EntityFrameworkCore;
using MyDbContext;


namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new MyDbContext.MyDbContext();

            //db.Users.Add(new MyDbContext.User()
            //{
            //    Name = "Vasul",
            //    Email = "vasul@gmail.com",
            //    Password = "12345"
            //});
            //db.SaveChanges();

            var user = db.Users.Include(x => x.Orders).ThenInclude(x => x.Items).FirstOrDefault(x => x.Email.ToLower().Equals("vasul@gmail.com".ToLower()));
            
            //if (user != null)
            //{
            //    db.Orders.Add(new Order()
            //    {
            //        UserId = user.Id,
            //        Name = "Many Apples",
            //        Description = "Sweet apples",
            //        Discount = 0,
            //        Items = new List<Item>()
            //        {
            //            new Item()
            //            {
            //                Name = "Carrot",
            //                Weight = 2.3F,
            //                Height = 15,
            //                Width = 1.5F,
            //                Price = 9.99M
            //            },
            //            new Item()
            //            {
            //                Name = "Apple",
            //                Weight = 10.3F,
            //                Height = 10,
            //                Width = 2.5F,
            //                Price = 100.99M
            //            }
            //        }
            //    });

            //    db.SaveChanges();
            //}
        }
    }
}