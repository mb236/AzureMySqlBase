using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AzureMySqlBase.DAL
{
    public class MyDbInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        //This method is called when the database is initialized
        protected override void Seed(DatabaseContext context)
        {
            //Code that fills the Database with initial data
            base.Seed(context);
        }
    }
}