﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RPG.Data;

#nullable disable

namespace RPG.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230107000454_Armor+Seeding")]
    partial class ArmorSeeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RPG.Models.Armor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.Property<decimal>("MagicProt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Material")
                        .HasColumnType("int");

                    b.Property<decimal>("MeleeProt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Protection")
                        .HasColumnType("int");

                    b.Property<decimal>("RangeProt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Slot")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Armor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Defense = 1,
                            MagicProt = 0.5m,
                            Material = 1,
                            MeleeProt = 1.5m,
                            Name = "Leather Hat",
                            Protection = 1,
                            RangeProt = 1.5m,
                            Slot = 0
                        },
                        new
                        {
                            Id = 2,
                            Defense = 2,
                            MagicProt = 0.5m,
                            Material = 1,
                            MeleeProt = 1.5m,
                            Name = "Leather Chest-piece",
                            Protection = 3,
                            RangeProt = 1.5m,
                            Slot = 2
                        },
                        new
                        {
                            Id = 3,
                            Defense = 2,
                            MagicProt = 0.5m,
                            Material = 1,
                            MeleeProt = 1.5m,
                            Name = "Leather Pants",
                            Protection = 3,
                            RangeProt = 1.5m,
                            Slot = 5
                        });
                });

            modelBuilder.Entity("RPG.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ArmorId")
                        .HasColumnType("int");

                    b.Property<int>("Class")
                        .HasColumnType("int");

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.Property<int>("Dexterity")
                        .HasColumnType("int");

                    b.Property<int>("HP")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<int>("MaxHP")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArmorId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("RPG.Models.Character", b =>
                {
                    b.HasOne("RPG.Models.Armor", null)
                        .WithMany("CharacterId")
                        .HasForeignKey("ArmorId");
                });

            modelBuilder.Entity("RPG.Models.Armor", b =>
                {
                    b.Navigation("CharacterId");
                });
#pragma warning restore 612, 618
        }
    }
}
