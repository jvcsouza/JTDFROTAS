﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using JTDLib;

namespace JTDLib.Migrations
{
    [DbContext(typeof(JTDContext))]
    [Migration("20191107014109_addIsMainToPhones")]
    partial class addIsMainToPhones
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JTDLib.Model.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Act");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("JTDLib.Model.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Act");

                    b.Property<string>("Name");

                    b.Property<int?>("StateId");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("JTDLib.Model.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Activity");

                    b.Property<string>("Cnpj");

                    b.Property<string>("FantasyName");

                    b.Property<int?>("PersonId");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("JTDLib.Model.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cpf");

                    b.Property<int?>("PersonId");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("JTDLib.Model.License", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Licenses");
                });

            modelBuilder.Entity("JTDLib.Model.Maintenance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("MaintenanceTypeId");

                    b.Property<decimal>("TotalCust");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MaintenanceTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Maintenances");
                });

            modelBuilder.Entity("JTDLib.Model.MaintenancePart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amont");

                    b.Property<int?>("MaintenanceId");

                    b.Property<int?>("PartId");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("MaintenanceId");

                    b.HasIndex("PartId");

                    b.ToTable("MaintenanceParts");
                });

            modelBuilder.Entity("JTDLib.Model.MaintenanceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("MaintenanceTypes");
                });

            modelBuilder.Entity("JTDLib.Model.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Act");

                    b.Property<int?>("BrandId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("JTDLib.Model.Part", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<float>("Stock");

                    b.HasKey("Id");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("JTDLib.Model.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Act");

                    b.Property<string>("Address");

                    b.Property<int?>("CityId");

                    b.Property<string>("Name");

                    b.Property<string>("Number");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("JTDLib.Model.Phone", b =>
                {
                    b.Property<int>("PhoneId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contact");

                    b.Property<bool>("IsMain");

                    b.Property<int?>("PersonId");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("PhoneId");

                    b.HasIndex("PersonId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("JTDLib.Model.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Act");

                    b.Property<string>("Initials");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("JTDLib.Model.Travel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DestinyId");

                    b.Property<string>("LastChange");

                    b.Property<int?>("OriginId");

                    b.Property<int?>("PersonId");

                    b.Property<string>("RegistrationDate");

                    b.Property<decimal>("TotalKm");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("DestinyId");

                    b.HasIndex("OriginId");

                    b.HasIndex("PersonId");

                    b.HasIndex("UserId");

                    b.ToTable("Travels");
                });

            modelBuilder.Entity("JTDLib.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("JTDLib.Model.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Available");

                    b.Property<decimal>("AverageCostPerKm");

                    b.Property<string>("Board");

                    b.Property<bool>("InMaintenance");

                    b.Property<string>("LastChange");

                    b.Property<string>("LastMaintenance");

                    b.Property<string>("MaintenanceEndDate");

                    b.Property<int?>("ModelId");

                    b.Property<int?>("PersonId");

                    b.Property<string>("RegistrationDate");

                    b.Property<int?>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.HasIndex("PersonId");

                    b.HasIndex("TypeId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("JTDLib.Model.VehiclesType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Act");

                    b.Property<string>("Name");

                    b.Property<int?>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("VehiclesTypes");
                });

            modelBuilder.Entity("JTDLib.Model.City", b =>
                {
                    b.HasOne("JTDLib.Model.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId");
                });

            modelBuilder.Entity("JTDLib.Model.Company", b =>
                {
                    b.HasOne("JTDLib.Model.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("JTDLib.Model.Guest", b =>
                {
                    b.HasOne("JTDLib.Model.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("JTDLib.Model.Maintenance", b =>
                {
                    b.HasOne("JTDLib.Model.MaintenanceType", "MaintenanceType")
                        .WithMany()
                        .HasForeignKey("MaintenanceTypeId");

                    b.HasOne("JTDLib.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JTDLib.Model.MaintenancePart", b =>
                {
                    b.HasOne("JTDLib.Model.Maintenance", "Maintenance")
                        .WithMany("Parts")
                        .HasForeignKey("MaintenanceId");

                    b.HasOne("JTDLib.Model.Part", "Part")
                        .WithMany("MaintenanceParts")
                        .HasForeignKey("PartId");
                });

            modelBuilder.Entity("JTDLib.Model.Model", b =>
                {
                    b.HasOne("JTDLib.Model.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");
                });

            modelBuilder.Entity("JTDLib.Model.Person", b =>
                {
                    b.HasOne("JTDLib.Model.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("JTDLib.Model.Phone", b =>
                {
                    b.HasOne("JTDLib.Model.Person")
                        .WithMany("Phones")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("JTDLib.Model.Travel", b =>
                {
                    b.HasOne("JTDLib.Model.City", "Destiny")
                        .WithMany()
                        .HasForeignKey("DestinyId");

                    b.HasOne("JTDLib.Model.City", "Origin")
                        .WithMany()
                        .HasForeignKey("OriginId");

                    b.HasOne("JTDLib.Model.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("JTDLib.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("JTDLib.Model.Vehicle", b =>
                {
                    b.HasOne("JTDLib.Model.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId");

                    b.HasOne("JTDLib.Model.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("JTDLib.Model.VehiclesType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("JTDLib.Model.VehiclesType", b =>
                {
                    b.HasOne("JTDLib.Model.VehiclesType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");
                });
        }
    }
}
