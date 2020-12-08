﻿using Microsoft.EntityFrameworkCore;
namespace Server.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) 
            : base(options)
        { 
            Database.EnsureCreated();
        }
 
        
    }
}