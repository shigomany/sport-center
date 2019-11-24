﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportCenter.Data;

namespace SportCenter.Migrations
{
    [DbContext(typeof(SportCenterContext))]
    partial class SportCenterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportCenter.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fio")
                        .IsRequired()
                        .HasColumnName("FIO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("SportCenter.Models.GroupTrain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<int>("IdTrainer")
                        .HasColumnName("ID_Trainer")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdTrainer");

                    b.ToTable("GroupTrain");
                });

            modelBuilder.Entity("SportCenter.Models.OrderGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<int>("IdClient")
                        .HasColumnName("ID_Client")
                        .HasColumnType("int");

                    b.Property<int>("IdGroupTrain")
                        .HasColumnName("ID_GroupTrain")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdClient");

                    b.HasIndex("IdGroupTrain");

                    b.ToTable("OrderGroup");
                });

            modelBuilder.Entity("SportCenter.Models.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fio")
                        .IsRequired()
                        .HasColumnName("FIO")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trainer");
                });

            modelBuilder.Entity("SportCenter.Models.GroupTrain", b =>
                {
                    b.HasOne("SportCenter.Models.Trainer", "IdTrainerNavigation")
                        .WithMany("GroupTrain")
                        .HasForeignKey("IdTrainer")
                        .HasConstraintName("FK_GroupTrain_Trainer_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SportCenter.Models.OrderGroup", b =>
                {
                    b.HasOne("SportCenter.Models.Client", "IdClientNavigation")
                        .WithMany("OrderGroup")
                        .HasForeignKey("IdClient")
                        .HasConstraintName("FK_OrderGroup_Client_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportCenter.Models.GroupTrain", "IdGroupTrainNavigation")
                        .WithMany("OrderGroup")
                        .HasForeignKey("IdGroupTrain")
                        .HasConstraintName("FK_OrderGroup_GroupTrain_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}