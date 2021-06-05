﻿// <auto-generated />
using System;
using ArtShowMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArtShowMVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ArtShowMVC.Models.ArtWorksModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ArtsitId")
                        .HasColumnType("int");

                    b.Property<int?>("ArtsitsModelId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtsitId");

                    b.HasIndex("ArtsitsModelId");

                    b.HasIndex("UserId");

                    b.ToTable("ArtWorks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtsitId = 2,
                            Image = "https://arabartforsale.com/uploads/artworks/1621526489_file.jpeg",
                            Price = 350,
                            Title = "African Girl",
                            UserId = 0
                        },
                        new
                        {
                            Id = 2,
                            ArtsitId = 4,
                            Image = "https://i.pinimg.com/564x/19/75/d6/1975d6e559da17936176eb6168161089.jpg",
                            Price = 400,
                            Title = "Beach Girl",
                            UserId = 0
                        },
                        new
                        {
                            Id = 3,
                            ArtsitId = 4,
                            Image = "https://i.pinimg.com/564x/b5/97/59/b597595d747bde7c979c9e4a37e2c674.jpg",
                            Price = 450,
                            Title = "Health Heroes",
                            UserId = 0
                        },
                        new
                        {
                            Id = 4,
                            ArtsitId = 3,
                            Image = "https://i.pinimg.com/564x/ef/6b/11/ef6b11c49ea530a0420252f6defb8904.jpg",
                            Price = 500,
                            Title = "Peace",
                            UserId = 0
                        },
                        new
                        {
                            Id = 5,
                            ArtsitId = 3,
                            Image = "https://i.pinimg.com/564x/16/e4/64/16e464c0cab9851c52eed6688889bc25.jpg",
                            Price = 550,
                            Title = "Mditate Look",
                            UserId = 0
                        },
                        new
                        {
                            Id = 6,
                            ArtsitId = 2,
                            Image = "https://i.pinimg.com/564x/0d/e5/54/0de554e7bdb9b876fd7a7138c70cdb2c.jpg",
                            Price = 600,
                            Title = "Playing Music",
                            UserId = 0
                        },
                        new
                        {
                            Id = 7,
                            ArtsitId = 1,
                            Image = " https://i.pinimg.com/564x/da/b4/83/dab483b7b0e472a8777ab008bb06dba3.jpg",
                            Price = 650,
                            Title = "Look Of Hope",
                            UserId = 0
                        },
                        new
                        {
                            Id = 8,
                            ArtsitId = 2,
                            Image = "https://i.pinimg.com/564x/b6/97/25/b6972560735a5eccba28aab8cf37dd92.jpg",
                            Price = 700,
                            Title = "Flower Girl",
                            UserId = 0
                        },
                        new
                        {
                            Id = 9,
                            ArtsitId = 1,
                            Image = "https://i.pinimg.com/474x/24/f9/54/24f9540c894b2756ff42dc0f8dbf2f76.jpg",
                            Price = 750,
                            Title = "Playing Music",
                            UserId = 0
                        });
                });

            modelBuilder.Entity("ArtShowMVC.Models.ArtsitsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("NumberPhone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Artsits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mousa Fahad ",
                            NumberPhone = 553478768
                        },
                        new
                        {
                            Id = 2,
                            Name = " Afnan Ali",
                            NumberPhone = 50754676
                        },
                        new
                        {
                            Id = 3,
                            Name = "Amal Alshehri",
                            NumberPhone = 557779835
                        },
                        new
                        {
                            Id = 4,
                            Name = "Hassan Khiled",
                            NumberPhone = 53769487
                        });
                });

            modelBuilder.Entity("ArtShowMVC.Models.ProfileModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("First_Name")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("Last_Name")
                        .HasColumnType("text");

                    b.Property<int>("Phone_Number")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profile");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            First_Name = "Shahad",
                            Gender = "Female",
                            Last_Name = "Alshehri",
                            Phone_Number = 503664482,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            First_Name = "Ali",
                            Gender = "Male",
                            Last_Name = "Hassan",
                            Phone_Number = 553388292,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            First_Name = "sara",
                            Gender = "Female",
                            Last_Name = "Ali",
                            Phone_Number = 508194230,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("ArtShowMVC.Models.UsersModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "0987",
                            Username = "shahad123"
                        },
                        new
                        {
                            Id = 2,
                            Password = "1234",
                            Username = "ali123"
                        },
                        new
                        {
                            Id = 3,
                            Password = "5678",
                            Username = "sara123"
                        });
                });

            modelBuilder.Entity("ArtShowMVC.Models.ArtWorksModel", b =>
                {
                    b.HasOne("ArtShowMVC.Models.ArtWorksModel", "Artsit")
                        .WithMany()
                        .HasForeignKey("ArtsitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArtShowMVC.Models.ArtsitsModel", null)
                        .WithMany("ArtWorks")
                        .HasForeignKey("ArtsitsModelId");

                    b.HasOne("ArtShowMVC.Models.UsersModel", "User")
                        .WithMany("ArtWorks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArtShowMVC.Models.ProfileModel", b =>
                {
                    b.HasOne("ArtShowMVC.Models.UsersModel", "User")
                        .WithOne("Profile")
                        .HasForeignKey("ArtShowMVC.Models.ProfileModel", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}