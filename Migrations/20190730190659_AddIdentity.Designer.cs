﻿// <auto-generated />
using System;
using BugReportingManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BugReportingManagement.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190730190659_AddIdentity")]
    partial class AddIdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BugReportingManagement.Models.BugPriorities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BugPriorityType")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("BugPriorities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BugPriorityType = "Low"
                        },
                        new
                        {
                            Id = 2,
                            BugPriorityType = "Medium"
                        },
                        new
                        {
                            Id = 3,
                            BugPriorityType = "High"
                        },
                        new
                        {
                            Id = 4,
                            BugPriorityType = "High"
                        });
                });

            modelBuilder.Entity("BugReportingManagement.Models.BugStatuses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BugStatusType")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("BugStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BugStatusType = "New"
                        },
                        new
                        {
                            Id = 2,
                            BugStatusType = "Assigned"
                        },
                        new
                        {
                            Id = 3,
                            BugStatusType = "Deferred"
                        },
                        new
                        {
                            Id = 4,
                            BugStatusType = "Dropped"
                        },
                        new
                        {
                            Id = 5,
                            BugStatusType = "Completed"
                        },
                        new
                        {
                            Id = 6,
                            BugStatusType = "Closed"
                        });
                });

            modelBuilder.Entity("BugReportingManagement.Models.Bugs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Attachment");

                    b.Property<string>("BugClosedBy")
                        .IsRequired();

                    b.Property<DateTime>("BugClosedOn");

                    b.Property<string>("BugCreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("BugCreatedOn");

                    b.Property<int>("BugPriorityId");

                    b.Property<string>("BugResolutionSummary")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<int>("BugStatusId");

                    b.Property<int>("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("BugPriorityId");

                    b.HasIndex("BugStatusId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Bugs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Attachment = "",
                            BugClosedBy = "Scott Jackson",
                            BugClosedOn = new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BugCreatedBy = "Jim Mozin",
                            BugCreatedOn = new DateTime(2019, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BugPriorityId = 1,
                            BugResolutionSummary = "show denied is including the other statuses - should be isolated to denied only",
                            BugStatusId = 1,
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 2,
                            Attachment = "",
                            BugClosedBy = "Scott Jackson",
                            BugClosedOn = new DateTime(2019, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BugCreatedBy = "Peter Oganwu",
                            BugCreatedOn = new DateTime(2019, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BugPriorityId = 1,
                            BugResolutionSummary = "show denied is including the other statuses - should be isolated to denied only",
                            BugStatusId = 2,
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 3,
                            Attachment = "",
                            BugClosedBy = "Scott Jackson",
                            BugClosedOn = new DateTime(2019, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BugCreatedBy = "Adam Wattt",
                            BugCreatedOn = new DateTime(2019, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BugPriorityId = 2,
                            BugResolutionSummary = "show denied is including the other statuses - should be isolated to denied only",
                            BugStatusId = 2,
                            ProjectId = 2
                        },
                        new
                        {
                            Id = 4,
                            Attachment = "",
                            BugClosedBy = "Scott Jackson",
                            BugClosedOn = new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BugCreatedBy = "Jim Mozin",
                            BugCreatedOn = new DateTime(2019, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BugPriorityId = 2,
                            BugResolutionSummary = "show denied is including the other statuses - should be isolated to denied only",
                            BugStatusId = 3,
                            ProjectId = 3
                        });
                });

            modelBuilder.Entity("BugReportingManagement.Models.Locations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("TesterId");

                    b.HasKey("Id");

                    b.HasIndex("TesterId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Test Server",
                            TesterId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Production Server",
                            TesterId = 3
                        },
                        new
                        {
                            Id = 3,
                            Name = "Production Server",
                            TesterId = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Test Server",
                            TesterId = 4
                        },
                        new
                        {
                            Id = 5,
                            Name = "Test Server",
                            TesterId = 5
                        });
                });

            modelBuilder.Entity("BugReportingManagement.Models.ProjectAdmins", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmPassword")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("ProjectAdmins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConfirmPassword = "AAAAA",
                            FirstName = "Peter",
                            LastName = "Oganwu",
                            Password = "AAAAA"
                        },
                        new
                        {
                            Id = 2,
                            ConfirmPassword = "AAAAA",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "AAAAA"
                        },
                        new
                        {
                            Id = 3,
                            ConfirmPassword = "AAAAA",
                            FirstName = "Dennis",
                            LastName = "Smith",
                            Password = "AAAAA"
                        },
                        new
                        {
                            Id = 4,
                            ConfirmPassword = "AAAAA",
                            FirstName = "Peter",
                            LastName = "Brian",
                            Password = "AAAAA"
                        },
                        new
                        {
                            Id = 5,
                            ConfirmPassword = "AAAAA",
                            FirstName = "Brian",
                            LastName = "Hale",
                            Password = "AAAAA"
                        });
                });

            modelBuilder.Entity("BugReportingManagement.Models.Projects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Some description",
                            ModifiedOn = new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Reward Bank"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Some description1",
                            ModifiedOn = new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "TC Energy"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Some description2",
                            ModifiedOn = new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Canadian Natural Resources"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Some description3",
                            ModifiedOn = new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "TransAlta"
                        });
                });

            modelBuilder.Entity("BugReportingManagement.Models.Testers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<int>("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Testers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Peter",
                            LastName = "Oganwu",
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "John",
                            LastName = "Doe",
                            ProjectId = 2
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Dennis",
                            LastName = "Smith",
                            ProjectId = 2
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Peter",
                            LastName = "Brian",
                            ProjectId = 3
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Brian",
                            LastName = "Hale",
                            ProjectId = 4
                        });
                });

            modelBuilder.Entity("BugReportingManagement.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmPassword");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<int>("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConfirmPassword = "AAAAA",
                            Email = "abc@abc.com",
                            FirstName = "Peter",
                            LastName = "Oganwu",
                            Password = "AAAAA",
                            Phone = "403-123-1111",
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 2,
                            ConfirmPassword = "AAAAA",
                            Email = "abc@abc.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "AAAAA",
                            Phone = "403-123-2222",
                            ProjectId = 2
                        },
                        new
                        {
                            Id = 3,
                            ConfirmPassword = "AAAAA",
                            Email = "abc@abc.com",
                            FirstName = "Dennis",
                            LastName = "Smith",
                            Password = "AAAAA",
                            Phone = "403-123-3333",
                            ProjectId = 3
                        },
                        new
                        {
                            Id = 4,
                            ConfirmPassword = "AAAAA",
                            Email = "abc@abc.com",
                            FirstName = "Peter",
                            LastName = "Brian",
                            Password = "AAAAA",
                            Phone = "403-123-4444",
                            ProjectId = 4
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BugReportingManagement.Models.Bugs", b =>
                {
                    b.HasOne("BugReportingManagement.Models.BugPriorities", "BugPriority")
                        .WithMany("Bugs")
                        .HasForeignKey("BugPriorityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BugReportingManagement.Models.BugStatuses", "BugStatus")
                        .WithMany("Bugs")
                        .HasForeignKey("BugStatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BugReportingManagement.Models.Projects", "Project")
                        .WithMany("Bugs")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BugReportingManagement.Models.Locations", b =>
                {
                    b.HasOne("BugReportingManagement.Models.Testers", "Tester")
                        .WithMany("Locations")
                        .HasForeignKey("TesterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BugReportingManagement.Models.Testers", b =>
                {
                    b.HasOne("BugReportingManagement.Models.Projects", "Project")
                        .WithMany("Testers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BugReportingManagement.Models.Users", b =>
                {
                    b.HasOne("BugReportingManagement.Models.Projects", "Project")
                        .WithMany("Users")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
