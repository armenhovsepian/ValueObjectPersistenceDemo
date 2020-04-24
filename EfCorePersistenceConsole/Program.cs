using EfCorePersistenceConsole.Data;
using EfCorePersistenceConsole.Models;
using System;

namespace EfCorePersistenceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Create();
        }


        static void Create()
        {
            using (var ctx = new EFCoreDbContext())
            {
                var order = new Order(
                    new OrderRowGuid(Guid.NewGuid()),
                    new OrderAmount(55),
                    new OrderDate(DateTime.Now));

                ctx.Orders.Add(order);
                ctx.SaveChanges();
            }
        }
    }
}
