﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School.Data;

namespace School.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20201111200419_dodo")]
    partial class dodo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("School.Models.Dolznost", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("NaimenovanieDolznosti")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obyazannosti")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Oklad")
                        .HasColumnType("int");

                    b.Property<long?>("StaffID")
                        .HasColumnType("bigint");

                    b.Property<string>("Trebovaniya")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("StaffID");

                    b.ToTable("Dolznost");
                });

            modelBuilder.Entity("School.Models.Staff", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("DolznostID")
                        .HasColumnType("bigint");

                    b.Property<string>("FIO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Old")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pasport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("School.Models.Dolznost", b =>
                {
                    b.HasOne("School.Models.Staff", null)
                        .WithMany("Dolznost")
                        .HasForeignKey("StaffID");
                });

            modelBuilder.Entity("School.Models.Staff", b =>
                {
                    b.Navigation("Dolznost");
                });
#pragma warning restore 612, 618
        }
    }
}
