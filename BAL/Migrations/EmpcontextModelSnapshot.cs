﻿// <auto-generated />
using System;
using BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BLL.Migrations
{
    [DbContext(typeof(Empcontext))]
    partial class EmpcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BLL.Models.Employee", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpId"), 1L, 1);

                    b.Property<string>("EmpDep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EmpDob")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmpEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Empgender")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpId");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            EmpId = 1,
                            EmpDep = "Devloper",
                            EmpDob = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmpEmail = "jhon@gmail.com",
                            EmpName = "Jhon",
                            Empgender = "Male"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
