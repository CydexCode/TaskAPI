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
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=Cydex ; Database=TodoDb ; Integrated Security=true ; TrustServerCertificate=true  ";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author {Id=1,FullName="sachi buddhika"},
                new Author {Id=2,FullName="smith Perera"},
                new Author {Id=3,FullName="maxwell dek"}

            });

            modelBuilder.Entity<Todo>().HasData(new Todo[]
            {
                new Todo
                {
                 Id = 1,
                Title = "Test Title 01",
                Description = "Test Description 01",
                CreatedDate = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId=1
                },
              
                new Todo
                {
                    Id = 2,
                Title = "Test Title 01",
                Description = "Test Description 01",
                CreatedDate = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                    AuthorId=2
                },

                 new Todo
                {
                     Id = 3,
                Title = "Test Title 01",
                Description = "Test Description 01",
                CreatedDate = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                    AuthorId=1
                },

            });
        }
    }
}



