
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AzureMySqlBase.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DatabaseContext")
        {
            Database.SetInitializer(new MyDbInitializer());
        }
        
        //Here you can write Tables as Propertiers just like: DbSet<Highscores> Highscores { get; set; }
    }
}