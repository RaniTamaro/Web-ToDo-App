using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using todo_domain_entities.Data.Models;

namespace todo_domain_entities.Context
{
    public class ToDoContext : DbContext
    {
        public ToDoContext()
        {
            Database.EnsureCreated();
        }

        public ToDoContext(DbContextOptions<ToDoContext> options)
            : base(options)
        {
        }

        public DbSet<ToDoList> Lists { get; set; }

        public DbSet<ToDoTask> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ToDoApplicationInterview;Trusted_Connection=True;MultipleActiveResultSets=True;");
        }
    }
}
