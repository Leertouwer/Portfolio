﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchaakData;

namespace Schaak.Migrations.Appl
{
    [DbContext(typeof(ApplContext))]
    [Migration("20191025162055_25okt1")]
    partial class _25okt1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SchaakData.Contestent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EnlistDate");

                    b.Property<int>("TournementId");

                    b.Property<string>("UsersId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Contestent");
                });

            modelBuilder.Entity("SchaakData.Tournement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime?>("RegistrationEndDate");

                    b.Property<DateTime?>("RegistrationStartDate");

                    b.Property<DateTime>("TournementEndDate");

                    b.Property<DateTime>("TournementStartDate");

                    b.HasKey("Id");

                    b.ToTable("Tournement");
                });
#pragma warning restore 612, 618
        }
    }
}