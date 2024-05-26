﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using transport_business_project.Data;

#nullable disable

namespace transport_business_project.Migrations
{
    [DbContext(typeof(TransportContext))]
    [Migration("20240525234056_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("transport_business_project.Classes.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PlateNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("YearsOfExperience")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("transport_business_project.Classes.Route", b =>
                {
                    b.Property<int>("RouteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Distance")
                        .HasColumnType("REAL");

                    b.Property<string>("EndLocation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("EstimatedTime")
                        .HasColumnType("REAL");

                    b.Property<string>("StartLocation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RouteID");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("transport_business_project.Classes.Transport", b =>
                {
                    b.Property<int>("TransportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("MaintenanceDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TransportID");

                    b.ToTable("Transports");
                });
#pragma warning restore 612, 618
        }
    }
}