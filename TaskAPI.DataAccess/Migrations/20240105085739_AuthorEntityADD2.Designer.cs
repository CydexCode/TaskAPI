﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskAPI.DataAccess;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20240105085739_AuthorEntityADD2")]
    partial class AuthorEntityADD2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "sachi buddhika"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "smith Perera"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "maxwell dek"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            CreatedDate = new DateTime(2024, 1, 5, 14, 27, 39, 638, DateTimeKind.Local).AddTicks(594),
                            Description = "Test Description 01",
                            Due = new DateTime(2024, 1, 10, 14, 27, 39, 638, DateTimeKind.Local).AddTicks(612),
                            Status = 0,
                            Title = "Test Title 01"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            CreatedDate = new DateTime(2024, 1, 5, 14, 27, 39, 638, DateTimeKind.Local).AddTicks(623),
                            Description = "Test Description 01",
                            Due = new DateTime(2024, 1, 10, 14, 27, 39, 638, DateTimeKind.Local).AddTicks(624),
                            Status = 0,
                            Title = "Test Title 01"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            CreatedDate = new DateTime(2024, 1, 5, 14, 27, 39, 638, DateTimeKind.Local).AddTicks(627),
                            Description = "Test Description 01",
                            Due = new DateTime(2024, 1, 10, 14, 27, 39, 638, DateTimeKind.Local).AddTicks(628),
                            Status = 0,
                            Title = "Test Title 01"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.HasOne("TaskAPI.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}
