﻿// <auto-generated />
using AstrologyApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AstrologyApi.Migrations
{
    [DbContext(typeof(AstrologyApiContext))]
    partial class AstrologyApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AstrologyApi.Models.Sign", b =>
                {
                    b.Property<int>("SignId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Concentration")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Expression")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SignName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("SignId");

                    b.ToTable("Signs");

                    b.HasData(
                        new
                        {
                            SignId = 1,
                            Concentration = "action",
                            Description = "idealist",
                            Expression = "dominant",
                            SignName = "Aries"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
