using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;

namespace FoodBazarManagementSystem.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base (options)
        {

        }

        public DbSet<Fruit> fruits { get; set; }
        public DbSet<CustomerFeedback> getintouch { get; set; }
    }
}
