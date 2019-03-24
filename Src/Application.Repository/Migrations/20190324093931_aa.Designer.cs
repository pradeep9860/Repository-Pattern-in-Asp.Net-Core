﻿// <auto-generated />
using System;
using Application.Repository.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Application.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190324093931_aa")]
    partial class aa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Application.Core.Entity.MasterCompany", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ACID");

                    b.Property<string>("ADDRESS");

                    b.Property<string>("EMAIL");

                    b.Property<string>("FAX");

                    b.Property<DateTime>("FBDATE");

                    b.Property<string>("FBDATE_BS");

                    b.Property<DateTime>("FEDATE");

                    b.Property<string>("FEDATE_BS");

                    b.Property<int>("ISBRANCH");

                    b.Property<string>("NAME");

                    b.Property<string>("PhiscalID");

                    b.Property<string>("TELA");

                    b.Property<string>("VAT");

                    b.Property<string>("WEBSITE");

                    b.HasKey("Id");

                    b.ToTable("MasterCompany");
                });

            modelBuilder.Entity("Core.Entity.Company", b =>
                {
                    b.Property<string>("INITIAL")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ACID");

                    b.Property<string>("ADDRESS");

                    b.Property<string>("EMAIL");

                    b.Property<string>("FAX");

                    b.Property<DateTime>("FBDATE");

                    b.Property<string>("FBDATE_BS");

                    b.Property<DateTime>("FEDATE");

                    b.Property<string>("FEDATE_BS");

                    b.Property<string>("ID");

                    b.Property<int>("ISBRANCH");

                    b.Property<string>("NAME");

                    b.Property<string>("PhiscalID");

                    b.Property<string>("TELA");

                    b.Property<string>("VAT");

                    b.Property<string>("WEBSITE");

                    b.HasKey("INITIAL");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Core.Entity.Division", b =>
                {
                    b.Property<string>("INITIAL")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ACID");

                    b.Property<string>("COMADD");

                    b.Property<string>("COMID");

                    b.Property<string>("COMNAME");

                    b.Property<string>("ID");

                    b.Property<int>("MAIN");

                    b.Property<string>("MSG1");

                    b.Property<string>("MSG2");

                    b.Property<string>("MSG3");

                    b.Property<string>("NAME");

                    b.Property<string>("REMARKS");

                    b.Property<int>("RateGroupID");

                    b.Property<string>("TYPE");

                    b.HasKey("INITIAL");

                    b.ToTable("Division");
                });
#pragma warning restore 612, 618
        }
    }
}