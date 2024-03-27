﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoftUniSpaceConsoleWebApp.Data;

#nullable disable

namespace SoftUniSpaceConsoleWebApp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SoftUniSpaceConsoleWebApp.Data.Entities.Crew", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Rank")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Crewmen");
                });

            modelBuilder.Entity("SoftUniSpaceConsoleWebApp.Data.Entities.Ship", b =>
                {
                    b.Property<int>("ShipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ShipAge")
                        .HasColumnType("int");

                    b.Property<string>("ShipName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ShipId");

                    b.ToTable("Ship");
                });
#pragma warning restore 612, 618
        }
    }
}
