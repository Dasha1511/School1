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
    [Migration("20201112150243_rara")]
    partial class rara
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("School.Models.Class", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Bukva")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Godobuch")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Godsozd")
                        .HasColumnType("datetime2");

                    b.Property<long>("ID_class")
                        .HasColumnType("bigint");

                    b.Property<int>("Kolstu")
                        .HasColumnType("int");

                    b.Property<long?>("RaspisanieID")
                        .HasColumnType("bigint");

                    b.Property<long?>("StaffID")
                        .HasColumnType("bigint");

                    b.Property<long?>("StudentsID")
                        .HasColumnType("bigint");

                    b.Property<long?>("VidID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("RaspisanieID");

                    b.HasIndex("StudentsID");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("School.Models.Dolznost", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("ID_Dolznost")
                        .HasColumnType("bigint");

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

            modelBuilder.Entity("School.Models.Predmets", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("ID_Predmets")
                        .HasColumnType("bigint");

                    b.Property<string>("Naimenovanie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opisanie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("RaspisanieID")
                        .HasColumnType("bigint");

                    b.Property<long?>("StaffID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("RaspisanieID");

                    b.ToTable("Predmets");
                });

            modelBuilder.Entity("School.Models.Raspisanie", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("ClassID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Dennedely")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PredmetsID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Vremanachala")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Vremaokonch")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Raspisanie");
                });

            modelBuilder.Entity("School.Models.Staff", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ClassID")
                        .HasColumnType("bigint");

                    b.Property<long?>("DolznostID")
                        .HasColumnType("bigint");

                    b.Property<string>("FIO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ID_staff")
                        .HasColumnType("bigint");

                    b.Property<string>("Old")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pasport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PredmetsID")
                        .HasColumnType("bigint");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ClassID");

                    b.HasIndex("PredmetsID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("School.Models.Students", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ClassID")
                        .HasColumnType("bigint");

                    b.Property<string>("Dopinf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dr")
                        .HasColumnType("datetime2");

                    b.Property<string>("FIO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FIOfather")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FIOmother")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("School.Models.Vid", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("ClassID")
                        .HasColumnType("bigint");

                    b.Property<long>("ID_type")
                        .HasColumnType("bigint");

                    b.Property<string>("Naimenovanie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opisanie")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ClassID");

                    b.ToTable("Vid");
                });

            modelBuilder.Entity("School.Models.Class", b =>
                {
                    b.HasOne("School.Models.Raspisanie", null)
                        .WithMany("Class")
                        .HasForeignKey("RaspisanieID");

                    b.HasOne("School.Models.Students", null)
                        .WithMany("Class")
                        .HasForeignKey("StudentsID");
                });

            modelBuilder.Entity("School.Models.Dolznost", b =>
                {
                    b.HasOne("School.Models.Staff", null)
                        .WithMany("Dolznost")
                        .HasForeignKey("StaffID");
                });

            modelBuilder.Entity("School.Models.Predmets", b =>
                {
                    b.HasOne("School.Models.Raspisanie", null)
                        .WithMany("Predmets")
                        .HasForeignKey("RaspisanieID");
                });

            modelBuilder.Entity("School.Models.Staff", b =>
                {
                    b.HasOne("School.Models.Class", null)
                        .WithMany("Staff")
                        .HasForeignKey("ClassID");

                    b.HasOne("School.Models.Predmets", null)
                        .WithMany("Staff")
                        .HasForeignKey("PredmetsID");
                });

            modelBuilder.Entity("School.Models.Vid", b =>
                {
                    b.HasOne("School.Models.Class", null)
                        .WithMany("Vid")
                        .HasForeignKey("ClassID");
                });

            modelBuilder.Entity("School.Models.Class", b =>
                {
                    b.Navigation("Staff");

                    b.Navigation("Vid");
                });

            modelBuilder.Entity("School.Models.Predmets", b =>
                {
                    b.Navigation("Staff");
                });

            modelBuilder.Entity("School.Models.Raspisanie", b =>
                {
                    b.Navigation("Class");

                    b.Navigation("Predmets");
                });

            modelBuilder.Entity("School.Models.Staff", b =>
                {
                    b.Navigation("Dolznost");
                });

            modelBuilder.Entity("School.Models.Students", b =>
                {
                    b.Navigation("Class");
                });
#pragma warning restore 612, 618
        }
    }
}