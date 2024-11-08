﻿// <auto-generated />
using System;
using Diary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Diary.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241107171101_AddedSeedingDataDiaryEntry")]
    partial class AddedSeedingDataDiaryEntry
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.7.24405.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Diary.Models.DiaryEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DiaryEntries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Went hiking with Joe!",
                            DateCreated = new DateTime(2024, 11, 7, 19, 11, 0, 922, DateTimeKind.Local).AddTicks(9430),
                            Title = "Went Hiking"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Went shopping with Joe!",
                            DateCreated = new DateTime(2024, 11, 7, 19, 11, 0, 931, DateTimeKind.Local).AddTicks(3420),
                            Title = "Went Shopping"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Went diving with Joe!",
                            DateCreated = new DateTime(2024, 11, 7, 19, 11, 0, 931, DateTimeKind.Local).AddTicks(3430),
                            Title = "Went Diving"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
