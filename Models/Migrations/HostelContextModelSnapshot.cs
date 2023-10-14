﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Models.Migrations
{
    [DbContext(typeof(HostelContext))]
    partial class HostelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Models.Model.AccountPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Account")
                        .HasColumnType("text");

                    b.Property<string>("NameAccount")
                        .HasColumnType("text");

                    b.Property<string>("Subconto1")
                        .HasColumnType("text");

                    b.Property<string>("Subconto2")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AccountPlans");
                });

            modelBuilder.Entity("Models.Model.AdditionalOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdditionalId")
                        .HasColumnType("integer");

                    b.Property<int?>("ClientId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("Cost")
                        .HasColumnType("numeric");

                    b.Property<DateOnly?>("Date")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("AdditionalId");

                    b.HasIndex("ClientId");

                    b.ToTable("AdditionalOperations");
                });

            modelBuilder.Entity("Models.Model.AdditionalService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal?>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("AdditionalServices");
                });

            modelBuilder.Entity("Models.Model.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Fio")
                        .HasColumnType("text");

                    b.Property<string>("Passport")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Models.Model.JurnalProvodok", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AccountCr")
                        .HasColumnType("integer");

                    b.Property<int?>("AccountDt")
                        .HasColumnType("integer");

                    b.Property<int?>("AdditionalOperationId")
                        .HasColumnType("integer");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<decimal?>("Count")
                        .HasColumnType("numeric");

                    b.Property<DateOnly?>("DateOperation")
                        .HasColumnType("date");

                    b.Property<int?>("MainOperationId")
                        .HasColumnType("integer");

                    b.Property<string>("SubcontoCr1")
                        .HasColumnType("text");

                    b.Property<string>("SubcontoDt1")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AdditionalOperationId");

                    b.HasIndex("MainOperationId");

                    b.ToTable("JurnalProvodoks");
                });

            modelBuilder.Entity("Models.Model.MainOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClientId")
                        .HasColumnType("integer");

                    b.Property<bool?>("Condit")
                        .HasColumnType("boolean");

                    b.Property<decimal?>("Cost")
                        .HasColumnType("numeric");

                    b.Property<DateOnly?>("Date")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("DateEnd")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("DateStart")
                        .HasColumnType("date");

                    b.Property<decimal?>("Payed")
                        .HasColumnType("numeric");

                    b.Property<int?>("RoomsId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("RoomsId");

                    b.ToTable("MainOperations");
                });

            modelBuilder.Entity("Models.Model.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal?>("Price")
                        .HasColumnType("numeric");

                    b.Property<int?>("Rooms")
                        .HasColumnType("integer");

                    b.Property<decimal?>("Size")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Models.Model.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Fio")
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("Models.Model.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDone")
                        .HasColumnType("boolean");

                    b.Property<int?>("StaffId")
                        .HasColumnType("integer");

                    b.Property<string>("Task1")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Models.Model.AdditionalOperation", b =>
                {
                    b.HasOne("Models.Model.AdditionalService", "Additional")
                        .WithMany("AdditionalOperations")
                        .HasForeignKey("AdditionalId");

                    b.HasOne("Models.Model.Client", "Client")
                        .WithMany("AdditionalOperations")
                        .HasForeignKey("ClientId");

                    b.Navigation("Additional");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Models.Model.JurnalProvodok", b =>
                {
                    b.HasOne("Models.Model.AdditionalOperation", "AdditionalOperation")
                        .WithMany("JurnalProvodoks")
                        .HasForeignKey("AdditionalOperationId");

                    b.HasOne("Models.Model.MainOperation", "MainOperation")
                        .WithMany("JurnalProvodoks")
                        .HasForeignKey("MainOperationId");

                    b.Navigation("AdditionalOperation");

                    b.Navigation("MainOperation");
                });

            modelBuilder.Entity("Models.Model.MainOperation", b =>
                {
                    b.HasOne("Models.Model.Client", "Client")
                        .WithMany("MainOperations")
                        .HasForeignKey("ClientId");

                    b.HasOne("Models.Model.Room", "Rooms")
                        .WithMany("MainOperations")
                        .HasForeignKey("RoomsId");

                    b.Navigation("Client");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Models.Model.Task", b =>
                {
                    b.HasOne("Models.Model.Staff", "Staff")
                        .WithMany("Tasks")
                        .HasForeignKey("StaffId");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Models.Model.AdditionalOperation", b =>
                {
                    b.Navigation("JurnalProvodoks");
                });

            modelBuilder.Entity("Models.Model.AdditionalService", b =>
                {
                    b.Navigation("AdditionalOperations");
                });

            modelBuilder.Entity("Models.Model.Client", b =>
                {
                    b.Navigation("AdditionalOperations");

                    b.Navigation("MainOperations");
                });

            modelBuilder.Entity("Models.Model.MainOperation", b =>
                {
                    b.Navigation("JurnalProvodoks");
                });

            modelBuilder.Entity("Models.Model.Room", b =>
                {
                    b.Navigation("MainOperations");
                });

            modelBuilder.Entity("Models.Model.Staff", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
