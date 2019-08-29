using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BugReportingManagement.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //DBSET property types to query the database

        public DbSet<Bugs> Bugs { get; set; }
        public DbSet<BugPriorities> BugPriorities { get; set; }
        public DbSet<BugStatuses> BugStatuses { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<Projects> Projects { get; set; }
        //public DbSet<ProjectAdmins> ProjectAdmins { get; set; }

        public DbSet<Testers> Testers { get; set; }
        //public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            

            //Call Entity with the modelBuilder instance and pass the HasData method
            modelBuilder.Entity<BugPriorities>().HasData(
                new BugPriorities { Id = 1, BugPriorityType = "Low" },
                new BugPriorities { Id = 2, BugPriorityType = "Medium" },
                new BugPriorities { Id = 3, BugPriorityType = "High" },
                new BugPriorities { Id = 4, BugPriorityType = "High" }
            );

            modelBuilder.Entity<Bugs>().HasData(
                new Bugs
                {
                    Id = 1,
                    ProjectId = 1,
                    BugPriorityId = 1,
                    BugStatusId = 1,
                    BugCreatedBy = "Jim Mozin",
                    BugCreatedOn = DateTime.Parse("2019-02-28"),
                    BugClosedBy = "Scott Jackson",
                    BugClosedOn = DateTime.Parse("2019-03-21"),
                    BugResolutionSummary = "show denied is including the other statuses - should be isolated to denied only",
                    Attachment = ""
                },
                 new Bugs
                 {
                     Id = 2,
                     ProjectId = 1,
                     BugPriorityId = 1,
                     BugStatusId = 2,
                     BugCreatedBy = "Peter Oganwu",
                     BugCreatedOn = DateTime.Parse("2019-04-28"),
                     BugClosedBy = "Scott Jackson",
                     BugClosedOn = DateTime.Parse("2019-05-21"),
                     BugResolutionSummary = "show denied is including the other statuses - should be isolated to denied only",
                     Attachment = ""
                 },
                  new Bugs
                  {
                      Id = 3,
                      ProjectId = 2,
                      BugPriorityId = 2,
                      BugStatusId = 2,
                      BugCreatedBy = "Adam Wattt",
                      BugCreatedOn = DateTime.Parse("2019-03-28"),
                      BugClosedBy = "Scott Jackson",
                      BugClosedOn = DateTime.Parse("2019-04-21"),
                      BugResolutionSummary = "show denied is including the other statuses - should be isolated to denied only",
                      Attachment = ""
                  },
                   new Bugs
                   {
                       Id = 4,
                       ProjectId = 3,
                       BugPriorityId = 2,
                       BugStatusId = 3,
                       BugCreatedBy = "Jim Mozin",
                       BugCreatedOn = DateTime.Parse("2019-02-28"),
                       BugClosedBy = "Scott Jackson",
                       BugClosedOn = DateTime.Parse("2019-03-21"),
                       BugResolutionSummary = "show denied is including the other statuses - should be isolated to denied only",
                       Attachment = ""
                   }
                );
            modelBuilder.Entity<BugStatuses>().HasData(
                   new BugStatuses { Id = 1, BugStatusType = "New" },
                   new BugStatuses { Id = 2, BugStatusType = "Assigned" },
                   new BugStatuses { Id = 3, BugStatusType = "Deferred" },
                   new BugStatuses { Id = 4, BugStatusType = "Dropped" },
                   new BugStatuses { Id = 5, BugStatusType = "Completed" },
                   new BugStatuses { Id = 6, BugStatusType = "Closed" });

            modelBuilder.Entity<Projects>().HasData(
                   new Projects { Id = 1, Name = "Reward Bank", Description = "Some description", ModifiedOn = DateTime.Parse("2019-03-14") },
                   new Projects { Id = 2, Name = "TC Energy", Description = "Some description1", ModifiedOn = DateTime.Parse("2019-03-14") },
                   new Projects { Id = 3, Name = "Canadian Natural Resources", Description = "Some description2", ModifiedOn = DateTime.Parse("2019-03-14") },
                   new Projects { Id = 4, Name = "TransAlta", Description = "Some description3", ModifiedOn = DateTime.Parse("2019-03-14") }
                );
            modelBuilder.Entity<ProjectAdmins>().HasData(
                   new ProjectAdmins { Id = 1, FirstName = "Peter", LastName = "Oganwu", Password = "AAAAA", ConfirmPassword = "AAAAA"},
                   new ProjectAdmins { Id = 2, FirstName = "John", LastName = "Doe", Password = "AAAAA", ConfirmPassword = "AAAAA" },
                   new ProjectAdmins { Id = 3, FirstName = "Dennis", LastName = "Smith", Password = "AAAAA", ConfirmPassword = "AAAAA" },
                   new ProjectAdmins { Id = 4, FirstName = "Peter", LastName = "Brian", Password = "AAAAA", ConfirmPassword = "AAAAA" },
                   new ProjectAdmins { Id = 5, FirstName = "Brian", LastName = "Hale", Password = "AAAAA", ConfirmPassword = "AAAAA" });

            //modelBuilder.Entity<Users>().HasData(
            //       new Users { Id = 1, FirstName = "Peter", LastName = "Oganwu", Phone = "403-123-1111", Email = "abc@abc.com", ProjectId = 1, Password = "AAAAA", ConfirmPassword = "AAAAA" },
            //       new Users { Id = 2, FirstName = "John", LastName = "Doe", Phone = "403-123-2222", Email = "abc@abc.com", ProjectId = 2, Password = "AAAAA", ConfirmPassword = "AAAAA" },
            //       new Users { Id = 3, FirstName = "Dennis", LastName = "Smith", Phone = "403-123-3333", Email = "abc@abc.com", ProjectId = 3, Password = "AAAAA", ConfirmPassword = "AAAAA" },
            //       new Users { Id = 4, FirstName = "Peter", LastName = "Brian", Phone = "403-123-4444", Email = "abc@abc.com", ProjectId = 4, Password = "AAAAA", ConfirmPassword = "AAAAA" });

            modelBuilder.Entity<Testers>().HasData(

                   new Testers { Id = 1, ProjectId = 1, FirstName = "Peter", LastName = "Oganwu" },
                   new Testers { Id = 2, ProjectId = 2, FirstName = "John", LastName = "Doe" },
                   new Testers { Id = 3, ProjectId = 2, FirstName = "Dennis", LastName = "Smith" },
                   new Testers { Id = 4, ProjectId = 3, FirstName = "Peter", LastName = "Brian" },
                   new Testers { Id = 5, ProjectId = 4, FirstName = "Brian", LastName = "Hale" }
                );

            modelBuilder.Entity<Locations>().HasData(
                   new Locations { Id = 1, TesterId = 1, Name = "Test Server" },
                   new Locations { Id = 2, TesterId = 3, Name = "Production Server" },
                   new Locations { Id = 3, TesterId = 2, Name = "Production Server" },
                   new Locations { Id = 4, TesterId = 4, Name = "Test Server" },
                   new Locations { Id = 5, TesterId = 5, Name = "Test Server" }
                );
        }
    }
}
