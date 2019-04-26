namespace CityExam.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using CityExam.Models;

    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
            Database.SetInitializer(new DataIntializer());
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Street> Streets { get; set; }
    }
}