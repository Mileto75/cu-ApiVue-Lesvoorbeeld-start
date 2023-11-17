﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cu.ApiBasics.Lesvoorbeeld.Avond.Infrastructure.Data;

#nullable disable

namespace cu.ApiBasics.Lesvoorbeeld.Avond.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231115075733_AddDateOfBirth")]
    partial class AddDateOfBirth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "da98bb50-7ebd-4d35-9f1e-d8f1f2402586",
                            DateOfBirth = new DateTime(1972, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@products.com",
                            EmailConfirmed = false,
                            Firstname = "Bart",
                            Lastname = "Soete",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@PRODUCTS.COM",
                            NormalizedUserName = "ADMIN@PRODUCTS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKa1qBTpcU3pjxdFAU72Z50bu8nVTS8XYirRsbCuWiUJZGzDhVYXQXlMWkcM/dzYGg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d6732b4a-97ed-462a-adff-f12e2ef4c163",
                            TwoFactorEnabled = false,
                            UserName = "admin@products.com"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b12e8e95-3c56-4eb6-ba1e-9ca9e5580d91",
                            DateOfBirth = new DateTime(2010, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "user@products.com",
                            EmailConfirmed = false,
                            Firstname = "Mileto",
                            Lastname = "Di Marco",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@PRODUCTS.COM",
                            NormalizedUserName = "USER@PRODUCTS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPc53UA9N6E/ETKl9lH8ETSzHg+J9rUgM1aQa+PjrJe0GS6ZRNozIIzZW0rhS7FGdg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "548529b1-ebc0-4b48-b616-c45340f46b8f",
                            TwoFactorEnabled = false,
                            UserName = "user@products.com"
                        });
                });

            modelBuilder.Entity("cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Laptops"
                        },
                        new
                        {
                            Id = 2,
                            Name = "PC's"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Phones"
                        });
                });

            modelBuilder.Entity("cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 3,
                            Image = "phone.jpg",
                            Name = "Samsung L7",
                            Price = 456.23m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            Image = "phone.jpg",
                            Name = "Redmi Note7",
                            Price = 325.13m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Image = "laptop.jpg",
                            Name = "Dell Latitude",
                            Price = 1456.23m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Image = "laptop.jpg",
                            Name = "Dell Desktop",
                            Price = 856.3m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Image = "laptop.jpg",
                            Name = "IBook 7",
                            Price = 2456.00m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Image = "tablet.jpg",
                            Name = "Ipad12",
                            Price = 958.23m
                        });
                });

            modelBuilder.Entity("cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Entities.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Basic"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Luxury"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Student"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Family"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Office"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role",
                            ClaimValue = "Admin",
                            UserId = "1"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role",
                            ClaimValue = "User",
                            UserId = "2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProductProperty", b =>
                {
                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("PropertiesId")
                        .HasColumnType("int");

                    b.HasKey("ProductsId", "PropertiesId");

                    b.HasIndex("PropertiesId");

                    b.ToTable("ProductProperty");

                    b.HasData(
                        new
                        {
                            ProductsId = 1,
                            PropertiesId = 1
                        },
                        new
                        {
                            ProductsId = 1,
                            PropertiesId = 2
                        },
                        new
                        {
                            ProductsId = 1,
                            PropertiesId = 3
                        },
                        new
                        {
                            ProductsId = 2,
                            PropertiesId = 1
                        },
                        new
                        {
                            ProductsId = 2,
                            PropertiesId = 2
                        },
                        new
                        {
                            ProductsId = 2,
                            PropertiesId = 3
                        },
                        new
                        {
                            ProductsId = 3,
                            PropertiesId = 1
                        },
                        new
                        {
                            ProductsId = 3,
                            PropertiesId = 3
                        },
                        new
                        {
                            ProductsId = 4,
                            PropertiesId = 1
                        },
                        new
                        {
                            ProductsId = 5,
                            PropertiesId = 1
                        },
                        new
                        {
                            ProductsId = 5,
                            PropertiesId = 3
                        },
                        new
                        {
                            ProductsId = 6,
                            PropertiesId = 1
                        },
                        new
                        {
                            ProductsId = 6,
                            PropertiesId = 2
                        });
                });

            modelBuilder.Entity("cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Entities.Product", b =>
                {
                    b.HasOne("cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductProperty", b =>
                {
                    b.HasOne("cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Entities.Property", null)
                        .WithMany()
                        .HasForeignKey("PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
