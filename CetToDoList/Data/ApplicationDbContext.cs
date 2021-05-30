using System;
using System.Collections.Generic;
using System.Text;
using CetToDoList.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CetToDoList.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Todo> Todos { get; set; }

    }
}
