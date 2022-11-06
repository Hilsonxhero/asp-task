using System;
using System.Data.Entity;
using System.Linq;

namespace auth.Models
{
    //public class Article : DbContext
    //{
    //    // Your context has been configured to use a 'Article' connection string from your application's 
    //    // configuration file (App.config or Web.config). By default, this connection string targets the 
    //    // 'auth.Models.Article' database on your LocalDb instance. 
    //    // 
    //    // If you wish to target a different database and/or database provider, modify the 'Article' 
    //    // connection string in the application configuration file.
    //    public Article()
    //        : base("name=Article")
    //    {
    //    }

    //    // Add a DbSet for each entity type that you want to include in your model. For more information 
    //    // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

    //    // public virtual DbSet<MyEntity> MyEntities { get; set; }
    //}

    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}