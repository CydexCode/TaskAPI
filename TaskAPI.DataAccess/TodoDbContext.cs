using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TaskAPI.DataAccess
{
    public class TodoDbContext : DbContext
    {

        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=Cydex ; Database=TodoDb ; Integrated Security=true ; TrustServerCertificate=true  ";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(new Todo
            {
                Id = 1,
                Title = "Test Title 01",
                Description = "Test Description 01",
                CreatedDate = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            });


        }



    }
}



