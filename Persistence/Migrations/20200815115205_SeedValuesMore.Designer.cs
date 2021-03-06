﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200815115205_SeedValuesMore")]
    partial class SeedValuesMore
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("Domain.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Values");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hello, Ched"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Hello, Angie"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hello, Kyndal"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Hello, Brantly"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Hello, Noah"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
