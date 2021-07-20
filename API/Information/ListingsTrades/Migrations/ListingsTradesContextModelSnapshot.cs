﻿// <auto-generated />
using System;
using ListingsTrades.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ListingsTrades.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ListingsTrades.Models.Classifications", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Acct_Id")
                        .HasColumnType("int");

                    b.Property<int>("AgentAccount")
                        .HasColumnType("int");

                    b.Property<int>("AgentAccount_S")
                        .HasColumnType("int");

                    b.Property<bool>("AllowFeeDiscounting")
                        .HasColumnType("bit");

                    b.Property<int>("BrokerAccount")
                        .HasColumnType("int");

                    b.Property<int>("BrokerAccount_S")
                        .HasColumnType("int");

                    b.Property<bool>("ChargeHOFees")
                        .HasColumnType("bit");

                    b.Property<bool>("ChargePST")
                        .HasColumnType("bit");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CommissionPlan")
                        .HasColumnType("int");

                    b.Property<int>("CreditOffice")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Ends")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("FeeAccount")
                        .HasColumnType("int");

                    b.Property<string>("GST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InactiveDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ListStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NotIn231")
                        .HasColumnType("bit");

                    b.Property<decimal>("PSTRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RevenueAccount_S")
                        .HasColumnType("int");

                    b.Property<int>("TaxAccount")
                        .HasColumnType("int");

                    b.Property<decimal>("TaxRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classifications");
                });

            modelBuilder.Entity("ListingsTrades.Models.Conditions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Condition")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Conditions");
                });

            modelBuilder.Entity("ListingsTrades.Models.PropertyTypes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RentalType")
                        .HasColumnType("bit");

                    b.Property<bool>("Report2HO")
                        .HasColumnType("bit");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Type")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("PropertyTypes");
                });

            modelBuilder.Entity("ListingsTrades.Models.SourceOfBusiness", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SourceOfBusiness");
                });
#pragma warning restore 612, 618
        }
    }
}
