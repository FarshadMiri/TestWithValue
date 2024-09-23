﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestWithValue.Data;

#nullable disable

namespace TestWithValue.Data.Migrations
{
    [DbContext(typeof(TestWithValueDbContext))]
    [Migration("20240923043201_addtbl")]
    partial class addtbl
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TestWithValue.Domain.Enitities.Tbl_Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnswerScore")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("UserAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("UserId");

                    b.ToTable("Tbl_Answers");
                });

            modelBuilder.Entity("TestWithValue.Domain.Enitities.Tbl_Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<int>("MaxScore")
                        .HasColumnType("int");

                    b.Property<int>("MinScore")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Tbl_Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            MaxScore = 100,
                            MinScore = 90,
                            Name = "ایده‌آل‌گرا"
                        },
                        new
                        {
                            CategoryId = 2,
                            MaxScore = 89,
                            MinScore = 70,
                            Name = "واقع‌گرا"
                        },
                        new
                        {
                            CategoryId = 3,
                            MaxScore = 69,
                            MinScore = 50,
                            Name = "عمل‌گرا"
                        },
                        new
                        {
                            CategoryId = 4,
                            MaxScore = 49,
                            MinScore = 30,
                            Name = "لذت‌گرا"
                        },
                        new
                        {
                            CategoryId = 5,
                            MaxScore = 29,
                            MinScore = 10,
                            Name = "ایثارگر"
                        },
                        new
                        {
                            CategoryId = 6,
                            MaxScore = 9,
                            MinScore = 0,
                            Name = "فردگرا"
                        });
                });

            modelBuilder.Entity("TestWithValue.Domain.Enitities.Tbl_Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"));

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("QuestionId");

                    b.ToTable("Tbl_Questions");
                });

            modelBuilder.Entity("TestWithValue.Domain.Enitities.Tbl_User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Tbl_Users");
                });

            modelBuilder.Entity("TestWithValue.Domain.Enitities.Tbl_Answer", b =>
                {
                    b.HasOne("TestWithValue.Domain.Enitities.Tbl_Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestWithValue.Domain.Enitities.Tbl_User", "User")
                        .WithMany("Answers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestWithValue.Domain.Enitities.Tbl_Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("TestWithValue.Domain.Enitities.Tbl_User", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}