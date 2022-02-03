﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using movieapp.Models;

namespace movieapp.Migrations
{
    [DbContext(typeof(movieContext))]
    [Migration("20220203073418_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("movieapp.Models.Category", b =>
                {
                    b.Property<int>("CategoryNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryNumber");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            CategoryNumber = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryNumber = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryNumber = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryNumber = 4,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryNumber = 5,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryNumber = 6,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryNumber = 7,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryNumber = 8,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("movieapp.Models.formResponse", b =>
                {
                    b.Property<int>("MovieNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryNumber1")
                        .HasColumnType("INTEGER");

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

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovieNumber");

                    b.HasIndex("CategoryNumber1");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieNumber = 1,
                            CategoryNumber = 4,
                            Director = "Nathan Greno, Bryon Howard",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "Tangled",
                            Year = "2010"
                        },
                        new
                        {
                            MovieNumber = 2,
                            CategoryNumber = 2,
                            Director = "John Hughes",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Ferris Bueller's Day Off",
                            Year = "1986"
                        },
                        new
                        {
                            MovieNumber = 3,
                            CategoryNumber = 2,
                            Director = "Steve Rash",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Can't Buy Me Love",
                            Year = "1987"
                        });
                });

            modelBuilder.Entity("movieapp.Models.formResponse", b =>
                {
                    b.HasOne("movieapp.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryNumber1");
                });
#pragma warning restore 612, 618
        }
    }
}