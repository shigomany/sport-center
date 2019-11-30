﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportCenter.Data;

namespace SportCenter.Migrations
{
    [DbContext(typeof(SportCenterContext))]
    [Migration("20191130062333_CreateDB")]
    partial class CreateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportCenter.Models.Abonement", b =>
                {
                    b.Property<long>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateBlock")
                        .HasColumnType("date");

                    b.Property<int>("IdClient")
                        .HasColumnName("ID_Client")
                        .HasColumnType("int");

                    b.Property<int?>("IntervalBlock")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Term")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("time");

                    b.HasKey("Number")
                        .HasName("PK_Abonement_ID");

                    b.HasIndex("IdClient");

                    b.ToTable("Abonement");
                });

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

                    b.Property<int>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Role")
                        .HasColumnType("int")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdRole");

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

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("time");

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

            modelBuilder.Entity("SportCenter.Models.PersonalTrain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<int>("IdClient")
                        .HasColumnName("ID_Client")
                        .HasColumnType("int");

                    b.Property<int>("IdTrainer")
                        .HasColumnName("ID_Trainer")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("IdClient");

                    b.HasIndex("IdTrainer");

                    b.ToTable("PersonalTrain");
                });

            modelBuilder.Entity("SportCenter.Models.RequestAbonement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdClient")
                        .HasColumnName("ID_Client")
                        .HasColumnType("int");

                    b.Property<int>("Term")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("IdClient");

                    b.ToTable("RequestAbonement");
                });

            modelBuilder.Entity("SportCenter.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");
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

            modelBuilder.Entity("SportCenter.Models.Abonement", b =>
                {
                    b.HasOne("SportCenter.Models.Client", "IdClientNavigation")
                        .WithMany("Abonement")
                        .HasForeignKey("IdClient")
                        .HasConstraintName("FK_Abonement_Client_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SportCenter.Models.Client", b =>
                {
                    b.HasOne("SportCenter.Models.Role", "IdRoleNavigation")
                        .WithMany("Client")
                        .HasForeignKey("IdRole")
                        .HasConstraintName("FK_Client_Role_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("SportCenter.Models.PersonalTrain", b =>
                {
                    b.HasOne("SportCenter.Models.Client", "IdClientNavigation")
                        .WithMany("PersonalTrain")
                        .HasForeignKey("IdClient")
                        .HasConstraintName("FK_PersonalTrain_Client_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportCenter.Models.Trainer", "IdTrainerNavigation")
                        .WithMany("PersonalTrain")
                        .HasForeignKey("IdTrainer")
                        .HasConstraintName("FK_PersonalTrain_Trainer_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SportCenter.Models.RequestAbonement", b =>
                {
                    b.HasOne("SportCenter.Models.Client", "IdClientNavigation")
                        .WithMany("RequestAbonement")
                        .HasForeignKey("IdClient")
                        .HasConstraintName("FK_RequestAbonement_Client_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}