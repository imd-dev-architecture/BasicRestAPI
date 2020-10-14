﻿// <auto-generated />
using BasicRestAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BasicRestAPI.Migrations
{
    [DbContext(typeof(GarageDatabaseContext))]
    [Migration("20201008091848_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BasicRestAPI.Model.Domain.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Brand")
                        .HasColumnType("int");

                    b.Property<int>("GarageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasMaxLength(2048);

                    b.HasKey("Id");

                    b.HasIndex("GarageId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("BasicRestAPI.Model.Domain.Garage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasMaxLength(2048);

                    b.HasKey("Id");

                    b.ToTable("Garages");
                });

            modelBuilder.Entity("BasicRestAPI.Model.Domain.Car", b =>
                {
                    b.HasOne("BasicRestAPI.Model.Domain.Garage", "Garage")
                        .WithMany("Cars")
                        .HasForeignKey("GarageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
