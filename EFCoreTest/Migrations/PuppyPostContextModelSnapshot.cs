﻿// <auto-generated />
using EFCoreTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreTest.Migrations
{
    [DbContext(typeof(PuppyPostContext))]
    partial class PuppyPostContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreTest.Models.PuppyPost", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("coat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dateBorn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eyes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("puppyPosts");

                    b.HasData(
                        new
                        {
                            id = 1,
                            coat = "blue merle",
                            dateBorn = "12/12/2020",
                            description = "Ugly",
                            eyes = "blue",
                            imgUrl = "https://www.idontgiveoneshit.com/someimg",
                            name = "Sniffy",
                            price = "2000"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
