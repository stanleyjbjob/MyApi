﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyApi.Dal;

#nullable disable

namespace MyApi.Migrations
{
    [DbContext(typeof(MyDataContext))]
    [Migration("20221029133730_set_allow_null")]
    partial class set_allow_null
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyApi.Dal.DataGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("DataGroup");
                });

            modelBuilder.Entity("MyApi.Dal.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("MyApi.Dal.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DataGroup")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Department")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
