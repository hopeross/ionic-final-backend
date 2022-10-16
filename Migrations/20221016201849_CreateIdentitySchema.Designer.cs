﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using task_api.Migrations;

#nullable disable

namespace task_api.Migrations
{
    [DbContext(typeof(TaskDbContext))]
    [Migration("20221016201849_CreateIdentitySchema")]
    partial class CreateIdentitySchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("TaskId");

                    b.ToTable("Task");
                });
#pragma warning restore 612, 618
        }
    }
}
