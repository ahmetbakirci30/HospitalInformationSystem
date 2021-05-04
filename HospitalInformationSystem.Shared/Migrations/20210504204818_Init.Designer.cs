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
    [Migration("20210504204818_Init")]
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
                            Id = new Guid("77ea19a8-d0a4-4de7-acac-925a88f366bc"),
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
                            FileNo = 32154987431m,
                            FirstVisitDate = new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(3604),
                            Gender = 0,
                            Name = "Ahmet Bakırcı",
                            Natinality = "Syrian",
                            PhoneNumber = "+905383754105",
                            RecordCreationDate = new DateTime(2021, 5, 4, 23, 48, 18, 198, DateTimeKind.Local).AddTicks(9700),
                            Street = "Başak Caddesi"
                        },
                        new
                        {
                            Id = new Guid("5aac3544-2199-48ee-a536-8b63a4edaf0c"),
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
                            FileNo = 9874231674421m,
                            FirstVisitDate = new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4448),
                            Gender = 0,
                            Name = "Muhammet Bakırcı",
                            Natinality = "Syrian",
                            PhoneNumber = "+905365823893",
                            RecordCreationDate = new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4441),
                            Street = "Başak Caddesi"
                        },
                        new
                        {
                            Id = new Guid("b9c793fd-a2db-498a-91f4-7668219ca219"),
                            Address1 = "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya",
                            Address2 = "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya",
                            BirthDate = new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CitizenId = "59356489387",
                            City = "Konya",
                            ContactPerson = "Fuat Bakırcı",
                            ContactPhone = "+905366724096",
                            ContactRelation = "Brother",
                            Country = "Turkey",
                            Email = "ahmetbakirci30@gmail.com",
                            FileNo = 6516321616058m,
                            FirstVisitDate = new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4467),
                            Gender = 0,
                            Name = "Ahmet Nehhas",
                            Natinality = "Syrian",
                            PhoneNumber = "+905383754105",
                            RecordCreationDate = new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4465),
                            Street = "Başak Caddesi"
                        },
                        new
                        {
                            Id = new Guid("019b54d7-b44b-4ac0-833b-db09f7dbf3cf"),
                            Address1 = "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya",
                            Address2 = "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya",
                            BirthDate = new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CitizenId = "98632189317",
                            City = "Konya",
                            ContactPerson = "Fuat Bakırcı",
                            ContactPhone = "+905366724096",
                            ContactRelation = "Brother",
                            Country = "Turkey",
                            Email = "ahmetbakirci30@gmail.com",
                            FileNo = 354168102081m,
                            FirstVisitDate = new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4476),
                            Gender = 1,
                            Name = "Fatma Rıza",
                            Natinality = "Turkish",
                            PhoneNumber = "+905383754105",
                            RecordCreationDate = new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4474),
                            Street = "Başak Caddesi"
                        },
                        new
                        {
                            Id = new Guid("9477d78b-37b1-4ca6-8624-5391f341b751"),
                            Address1 = "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya",
                            Address2 = "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya",
                            BirthDate = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CitizenId = "96256489317",
                            City = "Konya",
                            ContactPerson = "Fuat Bakırcı",
                            ContactPhone = "+905366724096",
                            ContactRelation = "Brother",
                            Country = "Turkey",
                            Email = "ahmetbakirci30@gmail.com",
                            FileNo = 3234054987431m,
                            FirstVisitDate = new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4484),
                            Gender = 1,
                            Name = "Halide Bakırcı",
                            Natinality = "Syrian",
                            PhoneNumber = "+905383754105",
                            RecordCreationDate = new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4483),
                            Street = "Başak Caddesi"
                        },
                        new
                        {
                            Id = new Guid("46ccc5b8-c339-4bac-a03f-95222479e4cd"),
                            Address1 = "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya",
                            Address2 = "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya",
                            BirthDate = new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CitizenId = "50699827810",
                            City = "Konya",
                            ContactPerson = "Fuat Bakırcı",
                            ContactPhone = "+905366724096",
                            ContactRelation = "Brother",
                            Country = "Turkey",
                            Email = "amuhammetbakirci30@gmail.com",
                            FileNo = 9874231601491m,
                            FirstVisitDate = new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4493),
                            Gender = 0,
                            Name = "Nasır Bakırcı",
                            Natinality = "Iraqi",
                            PhoneNumber = "+905365823893",
                            RecordCreationDate = new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4491),
                            Street = "Başak Caddesi"
                        },
                        new
                        {
                            Id = new Guid("8d0ca88b-99b9-4122-add8-16ff615256ec"),
                            Address1 = "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya",
                            Address2 = "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya",
                            BirthDate = new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CitizenId = "59356409387",
                            City = "Konya",
                            ContactPerson = "Fuat Bakırcı",
                            ContactPhone = "+905366724096",
                            ContactRelation = "Brother",
                            Country = "Turkey",
                            Email = "ahmetbakirci30@gmail.com",
                            FileNo = 15163616058m,
                            FirstVisitDate = new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4501),
                            Gender = 1,
                            Name = "Ritta Safa",
                            Natinality = "Turkish",
                            PhoneNumber = "+905383754105",
                            RecordCreationDate = new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4499),
                            Street = "Başak Caddesi"
                        },
                        new
                        {
                            Id = new Guid("fde418b2-93f4-43b8-8bc1-281c80f96ce5"),
                            Address1 = "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya",
                            Address2 = "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya",
                            BirthDate = new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CitizenId = "92032189317",
                            City = "Konya",
                            ContactPerson = "Fuat Bakırcı",
                            ContactPhone = "+905366724096",
                            ContactRelation = "Brother",
                            Country = "Turkey",
                            Email = "ahmetbakirci30@gmail.com",
                            FileNo = 3544768102081m,
                            FirstVisitDate = new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4509),
                            Gender = 1,
                            Name = "Fatma Lale",
                            Natinality = "Turk",
                            PhoneNumber = "+905383754105",
                            RecordCreationDate = new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4507),
                            Street = "Başak Caddesi"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}