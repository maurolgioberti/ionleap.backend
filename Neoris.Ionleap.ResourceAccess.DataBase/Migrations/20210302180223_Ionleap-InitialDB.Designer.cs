﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Neoris.Ionleap.ResourceAccess.DataBase;

namespace Neoris.Ionleap.ResourceAccess.DataBase.Migrations
{
    [DbContext(typeof(IonleapContext))]
    [Migration("20210302180223_Ionleap-InitialDB")]
    partial class IonleapInitialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Neoris.Ionleap.ResourceAccess.Entities.Business.Brand", b =>
                {
                    b.Property<int>("Identity")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserCreatedIdentity")
                        .HasColumnName("UserCreatedId")
                        .HasColumnType("int");

                    b.Property<int?>("UserModifiedIdentity")
                        .HasColumnName("UserModifiedId")
                        .HasColumnType("int");

                    b.HasKey("Identity");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Identity = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Xiaomi",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 2,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Acer",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 3,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lenovo",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 4,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Netmak",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 5,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Asus",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 6,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Gygabyte",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 7,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "SFX",
                            UserCreatedIdentity = 0
                        });
                });

            modelBuilder.Entity("Neoris.Ionleap.ResourceAccess.Entities.Business.Category", b =>
                {
                    b.Property<int>("Identity")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserCreatedIdentity")
                        .HasColumnName("UserCreatedId")
                        .HasColumnType("int");

                    b.Property<int?>("UserModifiedIdentity")
                        .HasColumnName("UserModifiedId")
                        .HasColumnType("int");

                    b.HasKey("Identity");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Identity = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Laptops",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 2,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Camaras",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 3,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Adaptadores",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 4,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Headsets",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 5,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Discos",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 6,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Monitores",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 7,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Motherboards",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 8,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Memorias",
                            UserCreatedIdentity = 0
                        });
                });

            modelBuilder.Entity("Neoris.Ionleap.ResourceAccess.Entities.Business.Customer", b =>
                {
                    b.Property<int>("Identity")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BusinessPrice")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PersonalId")
                        .HasColumnType("bigint");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserCreatedIdentity")
                        .HasColumnName("UserCreatedId")
                        .HasColumnType("int");

                    b.Property<int?>("UserModifiedIdentity")
                        .HasColumnName("UserModifiedId")
                        .HasColumnType("int");

                    b.HasKey("Identity");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Identity = 1,
                            Address = "",
                            BusinessPrice = false,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "JC Gmz",
                            Email = "",
                            Mobile = "",
                            Name = "Juan Carlos",
                            PersonalId = 0L,
                            Salary = 0m,
                            Surname = "Gomez",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 2,
                            Address = "",
                            BusinessPrice = true,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Arnoldo",
                            Email = "",
                            Mobile = "",
                            Name = "Arnold",
                            PersonalId = 0L,
                            Salary = 0m,
                            Surname = "Schwarzenegger",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 3,
                            Address = "",
                            BusinessPrice = true,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Caratorcida",
                            Email = "",
                            Mobile = "",
                            Name = "Silvester",
                            PersonalId = 0L,
                            Salary = 0m,
                            Surname = "Stallone",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 4,
                            Address = "",
                            BusinessPrice = true,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Patadita",
                            Email = "",
                            Mobile = "",
                            Name = "Jean Claude",
                            PersonalId = 0L,
                            Salary = 0m,
                            Surname = "Van Damme",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 5,
                            Address = "",
                            BusinessPrice = false,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Captain Marvel",
                            Email = "",
                            Mobile = "",
                            Name = "Carol",
                            PersonalId = 0L,
                            Salary = 0m,
                            Surname = "Danvers",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 6,
                            Address = "",
                            BusinessPrice = false,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Batgirl",
                            Email = "",
                            Mobile = "",
                            Name = "Betty",
                            PersonalId = 0L,
                            Salary = 0m,
                            Surname = "Kane",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 7,
                            Address = "",
                            BusinessPrice = false,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Superwoman",
                            Email = "",
                            Mobile = "",
                            Name = "Kristin",
                            PersonalId = 0L,
                            Salary = 0m,
                            Surname = "Wells",
                            UserCreatedIdentity = 0
                        },
                        new
                        {
                            Identity = 8,
                            Address = "",
                            BusinessPrice = false,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Black Widow",
                            Email = "",
                            Mobile = "",
                            Name = "Natasha",
                            PersonalId = 0L,
                            Salary = 0m,
                            Surname = "Romanoff",
                            UserCreatedIdentity = 0
                        });
                });

            modelBuilder.Entity("Neoris.Ionleap.ResourceAccess.Entities.Business.Product", b =>
                {
                    b.Property<int>("Identity")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandIdentity")
                        .HasColumnName("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryIdentity")
                        .HasColumnName("CategoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceBusiness")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UserCreatedIdentity")
                        .HasColumnName("UserCreatedId")
                        .HasColumnType("int");

                    b.Property<int?>("UserModifiedIdentity")
                        .HasColumnName("UserModifiedId")
                        .HasColumnType("int");

                    b.Property<bool>("WebSite")
                        .HasColumnType("bit");

                    b.HasKey("Identity");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Neoris.Ionleap.ResourceAccess.Entities.Security.Permission", b =>
                {
                    b.Property<int>("Identity")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Controller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserCreatedIdentity")
                        .HasColumnName("UserCreatedId")
                        .HasColumnType("int");

                    b.Property<int?>("UserModifiedIdentity")
                        .HasColumnName("UserModifiedId")
                        .HasColumnType("int");

                    b.HasKey("Identity");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Neoris.Ionleap.ResourceAccess.Entities.Security.Role", b =>
                {
                    b.Property<int>("Identity")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserCreatedIdentity")
                        .HasColumnName("UserCreatedId")
                        .HasColumnType("int");

                    b.Property<int?>("UserModifiedIdentity")
                        .HasColumnName("UserModifiedId")
                        .HasColumnType("int");

                    b.HasKey("Identity");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Neoris.Ionleap.ResourceAccess.Entities.Security.RolePermission", b =>
                {
                    b.Property<int>("Identity")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PermissionIdentity")
                        .HasColumnName("PermissionId")
                        .HasColumnType("int");

                    b.Property<int>("RoleIdentity")
                        .HasColumnName("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserCreatedIdentity")
                        .HasColumnName("UserCreatedId")
                        .HasColumnType("int");

                    b.Property<int?>("UserModifiedIdentity")
                        .HasColumnName("UserModifiedId")
                        .HasColumnType("int");

                    b.HasKey("Identity");

                    b.HasIndex("PermissionIdentity");

                    b.HasIndex("RoleIdentity");

                    b.ToTable("RolesPermissions");
                });

            modelBuilder.Entity("Neoris.Ionleap.ResourceAccess.Entities.Security.User", b =>
                {
                    b.Property<int>("Identity")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeFileNumber")
                        .HasColumnType("int");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PersonalId")
                        .HasColumnType("bigint");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserCreatedIdentity")
                        .HasColumnName("UserCreatedId")
                        .HasColumnType("int");

                    b.Property<int?>("UserModifiedIdentity")
                        .HasColumnName("UserModifiedId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Identity");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Identity = 1,
                            Active = true,
                            DateBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateCreated = new DateTime(2021, 3, 2, 15, 2, 23, 406, DateTimeKind.Local).AddTicks(5559),
                            Email = "test",
                            EmployeeFileNumber = 1,
                            IsAdmin = true,
                            Name = "test",
                            Password = "fbwH0d4qexF+eBHYk6aQjzjtJawdPZcNzUd3Wo5CI6g=",
                            PasswordSalt = "I5YIl4ReQNAbYxMl9i7gBPhqSS+DukLWR0TEzp/90nA=",
                            ProfilePictureUrl = "test",
                            Surname = "test",
                            UserCreatedIdentity = 0,
                            Username = "test"
                        });
                });

            modelBuilder.Entity("Neoris.Ionleap.ResourceAccess.Entities.Security.UserRole", b =>
                {
                    b.Property<int>("Identity")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleIdentity")
                        .HasColumnName("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserCreatedIdentity")
                        .HasColumnName("UserCreatedId")
                        .HasColumnType("int");

                    b.Property<int>("UserIdentity")
                        .HasColumnName("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserModifiedIdentity")
                        .HasColumnName("UserModifiedId")
                        .HasColumnType("int");

                    b.HasKey("Identity");

                    b.HasIndex("RoleIdentity");

                    b.HasIndex("UserIdentity");

                    b.ToTable("UsersRoles");
                });

            modelBuilder.Entity("Neoris.Ionleap.ResourceAccess.Entities.Security.RolePermission", b =>
                {
                    b.HasOne("Neoris.Ionleap.ResourceAccess.Entities.Security.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionIdentity")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Neoris.Ionleap.ResourceAccess.Entities.Security.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleIdentity")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Neoris.Ionleap.ResourceAccess.Entities.Security.UserRole", b =>
                {
                    b.HasOne("Neoris.Ionleap.ResourceAccess.Entities.Security.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleIdentity")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Neoris.Ionleap.ResourceAccess.Entities.Security.User", "User")
                        .WithMany()
                        .HasForeignKey("UserIdentity")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
