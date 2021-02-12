﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesIssue.Data;

namespace issue_tracker_crud.Migrations
{
    [DbContext(typeof(RazorPagesIssueContext))]
    [Migration("20210212031754_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11");

            modelBuilder.Entity("issue_tracker_crud.Models.Issue", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsIssueOpen")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IssueAssigned")
                        .HasColumnType("INTEGER");

                    b.Property<string>("IssueDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("IssueLevel")
                        .HasColumnType("TEXT");

                    b.Property<string>("IssueTitle")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Issue");
                });
#pragma warning restore 612, 618
        }
    }
}
