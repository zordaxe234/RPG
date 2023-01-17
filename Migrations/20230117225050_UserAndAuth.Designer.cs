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
    [Migration("20230117225050_UserAndAuth")]
    partial class UserAndAuth
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

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.Property<decimal>("MagicProt")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("Material")
                        .HasColumnType("int");

                    b.Property<decimal>("MeleeProt")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Protection")
                        .HasColumnType("int");

                    b.Property<decimal>("RangeProt")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("Slot")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Armor");
                });

            modelBuilder.Entity("RPG.Models.CharArmor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int?>("ChestId")
                        .HasColumnType("int");

                    b.Property<int?>("FeetId")
                        .HasColumnType("int");

                    b.Property<int?>("FingerLId")
                        .HasColumnType("int");

                    b.Property<int?>("FingerRId")
                        .HasColumnType("int");

                    b.Property<int?>("HandsId")
                        .HasColumnType("int");

                    b.Property<int?>("HeadId")
                        .HasColumnType("int");

                    b.Property<int?>("LegsId")
                        .HasColumnType("int");

                    b.Property<int?>("NeckId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.HasIndex("ChestId");

                    b.HasIndex("FeetId");

                    b.HasIndex("FingerLId");

                    b.HasIndex("FingerRId");

                    b.HasIndex("HandsId");

                    b.HasIndex("HeadId");

                    b.HasIndex("LegsId");

                    b.HasIndex("NeckId");

                    b.ToTable("CharArmor");
                });

            modelBuilder.Entity("RPG.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Class")
                        .HasColumnType("int");

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.Property<int>("Dexterity")
                        .HasColumnType("int");

                    b.Property<int>("Hp")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<int>("MaxHp")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("RPG.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RPG.Models.CharArmor", b =>
                {
                    b.HasOne("RPG.Models.Character", null)
                        .WithOne("CharArmor")
                        .HasForeignKey("RPG.Models.CharArmor", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPG.Models.Armor", "Chest")
                        .WithMany()
                        .HasForeignKey("ChestId");

                    b.HasOne("RPG.Models.Armor", "Feet")
                        .WithMany()
                        .HasForeignKey("FeetId");

                    b.HasOne("RPG.Models.Armor", "FingerL")
                        .WithMany()
                        .HasForeignKey("FingerLId");

                    b.HasOne("RPG.Models.Armor", "FingerR")
                        .WithMany()
                        .HasForeignKey("FingerRId");

                    b.HasOne("RPG.Models.Armor", "Hands")
                        .WithMany()
                        .HasForeignKey("HandsId");

                    b.HasOne("RPG.Models.Armor", "Head")
                        .WithMany()
                        .HasForeignKey("HeadId");

                    b.HasOne("RPG.Models.Armor", "Legs")
                        .WithMany()
                        .HasForeignKey("LegsId");

                    b.HasOne("RPG.Models.Armor", "Neck")
                        .WithMany()
                        .HasForeignKey("NeckId");

                    b.Navigation("Chest");

                    b.Navigation("Feet");

                    b.Navigation("FingerL");

                    b.Navigation("FingerR");

                    b.Navigation("Hands");

                    b.Navigation("Head");

                    b.Navigation("Legs");

                    b.Navigation("Neck");
                });

            modelBuilder.Entity("RPG.Models.Character", b =>
                {
                    b.HasOne("RPG.Models.User", "User")
                        .WithMany("Characters")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RPG.Models.Character", b =>
                {
                    b.Navigation("CharArmor")
                        .IsRequired();
                });

            modelBuilder.Entity("RPG.Models.User", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
