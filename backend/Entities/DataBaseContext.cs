using System;
using Microsoft.EntityFrameworkCore;

namespace BackendAPI.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Users> User { get; set; }
        public DbSet<Form> ContactMsg { get; set; }


        // GIVING PREDIFINED DATA TO DATABASE 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // CREATING ADMIN USER
            modelBuilder.Entity<Users>().HasData(
                new Users
                {
                    UserId = 1,
                    Email = "admin@localhost",
                    Password = "Passcode1",
                    Role = Roles.Admin
                }
                );

            // CREATING Form
            modelBuilder.Entity<Form>().HasData(
                new Form
                {
                    Id = 1,
                    question0 = "sample",
                    question1 = "sample",
                    question2 = "sample",
                    question3 = "sample",
                    question4 = "sample",
                    question5 = "sample",
                    question6 = "sample",
                    question7 = "sample",
                    question8 = "sample",
                    question9 = "sample",
                    Email = "admin@localhost"
                });
        }
    }
}
