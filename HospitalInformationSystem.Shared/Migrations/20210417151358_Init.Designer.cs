﻿// <auto-generated />
using System;
using HospitalInformationSystem.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalInformationSystem.Shared.Migrations
{
    [DbContext(typeof(HospitalInformationSystemDbContext))]
    [Migration("20210417151358_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HospitalInformationSystem.Shared.Entities.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address1")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Address2")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CitizenId")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(65)
                        .HasColumnType("nvarchar(65)");

                    b.Property<string>("ContactPerson")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ContactPhone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("ContactRelation")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(65)
                        .HasColumnType("nvarchar(65)");

                    b.Property<string>("Email")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<decimal>("FileNo")
                        .HasColumnType("decimal(38,0)");

                    b.Property<DateTime?>("FirstVisitDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Natinality")
                        .HasMaxLength(65)
                        .HasColumnType("nvarchar(65)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("RecordCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Street")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("CitizenId")
                        .IsUnique();

                    b.HasIndex("FileNo")
                        .IsUnique();

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ef5c8981-5185-4f12-b8b4-9dffc5103e58"),
                            Address1 = "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya",
                            Address2 = "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya",
                            BirthDate = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CitizenId = "33356489317",
                            City = "Konya",
                            ContactPerson = "Fuat Bakırcı",
                            ContactPhone = "+905366724096",
                            ContactRelation = "Brother",
                            Country = "Turkey",
                            Email = "ahmetbakirci30@gmail.com",
                            FileNo = 1155540415m,
                            FirstVisitDate = new DateTime(2021, 4, 17, 15, 13, 58, 96, DateTimeKind.Utc).AddTicks(6271),
                            Gender = 0,
                            Name = "Ahmet Bakırcı",
                            Natinality = "Syrian",
                            PhoneNumber = "+905383754105",
                            RecordCreationDate = new DateTime(2021, 4, 17, 15, 13, 58, 96, DateTimeKind.Utc).AddTicks(5855),
                            Street = "Başak Caddesi"
                        },
                        new
                        {
                            Id = new Guid("1ced7357-0f1b-4b69-a4df-3c3b65d05d38"),
                            Address1 = "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya",
                            Address2 = "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya",
                            BirthDate = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CitizenId = "55693457810",
                            City = "Konya",
                            ContactPerson = "Fuat Bakırcı",
                            ContactPhone = "+905366724096",
                            ContactRelation = "Brother",
                            Country = "Turkey",
                            Email = "amuhammetbakirci30@gmail.com",
                            FileNo = 1246663973m,
                            FirstVisitDate = new DateTime(2021, 4, 17, 15, 13, 58, 96, DateTimeKind.Utc).AddTicks(6834),
                            Gender = 0,
                            Name = "Muhammet Bakırcı",
                            Natinality = "Syrian",
                            PhoneNumber = "+905365823893",
                            RecordCreationDate = new DateTime(2021, 4, 17, 15, 13, 58, 96, DateTimeKind.Utc).AddTicks(6831),
                            Street = "Başak Caddesi"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}