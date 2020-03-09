﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using cqrs_Test.Application.Interfaces;

namespace Customer_Handler.Migrations
{
    [DbContext(typeof(IContext))]
    [Migration("20200309112550_CustomerMigration")]
    partial class CustomerMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("cqrs_Test.Domain.Entities.CustomerPaymentCards", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("created_at")
                        .HasColumnType("bigint");

                    b.Property<string>("credit_card_number")
                        .HasColumnType("text");

                    b.Property<int>("customer_id")
                        .HasColumnType("integer");

                    b.Property<string>("exp_month")
                        .HasColumnType("text");

                    b.Property<string>("exp_year")
                        .HasColumnType("text");

                    b.Property<string>("name_on_card")
                        .HasColumnType("text");

                    b.Property<int>("postal_code")
                        .HasColumnType("integer");

                    b.Property<long>("updated_at")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("CPC");
                });

            modelBuilder.Entity("cqrs_Test.Domain.Entities.Customers", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("birthdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("created_at")
                        .HasColumnType("bigint");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("full_name")
                        .HasColumnType("text");

                    b.Property<int>("gender")
                        .HasColumnType("integer");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.Property<string>("phone_number")
                        .HasColumnType("text");

                    b.Property<string>("sex")
                        .HasColumnType("text");

                    b.Property<long>("updated_at")
                        .HasColumnType("bigint");

                    b.Property<string>("username")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
