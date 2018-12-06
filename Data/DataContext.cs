using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
            //nothing required here
        }

        //property name is db table name
        public DbSet<Value> Values {get; set;}


    }
}