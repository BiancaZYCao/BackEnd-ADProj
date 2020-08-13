using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class DbSeeder
    {
        public DbSeeder(TodoContext dbcontext)
        {
            /*
            User user = new User()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Daryl Kouk",
                Username = "Daryl",
                Password = encoder.Encode("Password")
            };
            dbcontext.Add(user);*/
            TodoItem tdi = new TodoItem()
            {
                Name = "Cook dinner",
                IsComplete = false,
                Secret = "Dangerous Secret info"
            };
            dbcontext.Add(tdi);

            dbcontext.SaveChanges();
        }

        
    }
}
