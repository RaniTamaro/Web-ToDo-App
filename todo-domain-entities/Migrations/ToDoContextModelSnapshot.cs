﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using todo_domain_entities.Context;

namespace todo_domain_entities.Migrations
{
    [DbContext(typeof(ToDoContext))]
    partial class ToDoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("todo_domain_entities.Data.Models.ToDoList", b =>
                {
                    b.Property<int>("ListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ListId");

                    b.ToTable("Lists");
                });

            modelBuilder.Entity("todo_domain_entities.Data.Models.ToDoTask", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ListId")
                        .HasColumnType("int");

                    b.Property<int?>("TDListListId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TaskCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TaskDescription")
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.Property<DateTime?>("TaskDueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TaskNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TaskRemindDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TaskStatus")
                        .HasColumnType("int");

                    b.Property<string>("TaskTag")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TaskTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("TaskId");

                    b.HasIndex("TDListListId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("todo_domain_entities.Data.Models.ToDoTask", b =>
                {
                    b.HasOne("todo_domain_entities.Data.Models.ToDoList", "TDList")
                        .WithMany("Tasks")
                        .HasForeignKey("TDListListId");

                    b.Navigation("TDList");
                });

            modelBuilder.Entity("todo_domain_entities.Data.Models.ToDoList", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}