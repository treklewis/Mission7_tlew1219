﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6_tlew1219.Models;

namespace Mission6_tlew1219.Migrations
{
    [DbContext(typeof(DateApplicationContext))]
    partial class DateApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission6_tlew1219.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("AppliationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("AppliationID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            AppliationID = 1,
                            Category = "Thriller",
                            Director = "Martin Scorcese",
                            Edited = true,
                            LentTo = "",
                            Notes = "Incredible",
                            Rating = "R",
                            Title = "The Departed",
                            Year = (ushort)2006
                        },
                        new
                        {
                            AppliationID = 2,
                            Category = "Adventure",
                            Director = "Kevin Lima, Chris Buck",
                            Edited = false,
                            LentTo = "",
                            Notes = "Thank you Phil Collins",
                            Rating = "G",
                            Title = "Tarzan",
                            Year = (ushort)1999
                        },
                        new
                        {
                            AppliationID = 3,
                            Category = "Mystery",
                            Director = "Christopher Nolan ",
                            Edited = true,
                            LentTo = "",
                            Notes = "Mind blowing",
                            Rating = "R",
                            Title = "Memento",
                            Year = (ushort)2000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
