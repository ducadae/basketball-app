﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("API.Models.Players", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Block")
                        .HasColumnType("INTEGER");

                    b.Property<string>("College")
                        .HasColumnType("TEXT");

                    b.Property<int>("DefReb")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DefensiveIQ")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Dribbling")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Dunk")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Durability")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("FreeThrow")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Handedness")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HelpDefense")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Layup")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LowPostTechnique")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("OffReb")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OffensiveIQ")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OffhandDribbling")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Passing")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PerimeterDefense")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PostDefense")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Potential")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quickness")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecondaryPosition")
                        .HasColumnType("TEXT");

                    b.Property<int>("ShotClose")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ShotLow")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ShotMed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ShotThreePoint")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Speed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Steal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Strength")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Vertical")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YearsPro")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
