﻿// <auto-generated />
using System;
using Kolokwium.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kolokwium.Migrations
{
    [DbContext(typeof(PjatkDbContext))]
    partial class PjatkDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Kolokwium.Models.File", b =>
                {
                    b.Property<int>("FileID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FileID"), 1L, 1);

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.HasKey("FileID");

                    b.HasIndex("TeamID");

                    b.ToTable("File");

                    b.HasData(
                        new
                        {
                            FileID = 1,
                            FileExtension = ".zip",
                            FileName = "Name1",
                            TeamID = 1
                        },
                        new
                        {
                            FileID = 2,
                            FileExtension = ".zip",
                            FileName = "Name2",
                            TeamID = 2
                        });
                });

            modelBuilder.Entity("Kolokwium.Models.Member", b =>
                {
                    b.Property<int>("MemberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberID"), 1L, 1);

                    b.Property<string>("MemberName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MemberNickName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MemberSurname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OrganizationID")
                        .HasColumnType("int");

                    b.HasKey("MemberID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("Member");

                    b.HasData(
                        new
                        {
                            MemberID = 1,
                            MemberName = "Andrzej",
                            MemberNickName = "AndrzejKowalski",
                            MemberSurname = "Kowalski",
                            OrganizationID = 0
                        },
                        new
                        {
                            MemberID = 2,
                            MemberName = "Maciej",
                            MemberNickName = "Nowak",
                            MemberSurname = "Nowak",
                            OrganizationID = 0
                        });
                });

            modelBuilder.Entity("Kolokwium.Models.Membership", b =>
                {
                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<DateTime>("MembershipDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.HasKey("MemberID");

                    b.ToTable("Membership");
                });

            modelBuilder.Entity("Kolokwium.Models.Organization", b =>
                {
                    b.Property<int>("OrganizationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrganizationID"), 1L, 1);

                    b.Property<string>("OrganizationDomain")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OrganizationName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("OrganizationID");

                    b.ToTable("Organization");

                    b.HasData(
                        new
                        {
                            OrganizationID = 1,
                            OrganizationDomain = "Home",
                            OrganizationName = "Organization1"
                        },
                        new
                        {
                            OrganizationID = 2,
                            OrganizationDomain = "Away",
                            OrganizationName = "Organization2"
                        });
                });

            modelBuilder.Entity("Kolokwium.Models.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamID"), 1L, 1);

                    b.Property<int>("OrganizationID")
                        .HasColumnType("int");

                    b.Property<string>("TeamDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TeamID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("Team");

                    b.HasData(
                        new
                        {
                            TeamID = 1,
                            OrganizationID = 1,
                            TeamDescription = "AAAAAAAAAA",
                            TeamName = "ABC"
                        },
                        new
                        {
                            TeamID = 2,
                            OrganizationID = 2,
                            TeamDescription = "BBBBBBB",
                            TeamName = "ADC"
                        });
                });

            modelBuilder.Entity("Kolokwium.Models.File", b =>
                {
                    b.HasOne("Kolokwium.Models.Team", "Team")
                        .WithMany("Files")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Kolokwium.Models.Member", b =>
                {
                    b.HasOne("Kolokwium.Models.Organization", "Organization")
                        .WithMany("Members")
                        .HasForeignKey("OrganizationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Kolokwium.Models.Membership", b =>
                {
                    b.HasOne("Kolokwium.Models.Member", "Member")
                        .WithMany("Memberships")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Kolokwium.Models.Team", b =>
                {
                    b.HasOne("Kolokwium.Models.Organization", "Organization")
                        .WithMany("Teams")
                        .HasForeignKey("OrganizationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Kolokwium.Models.Member", b =>
                {
                    b.Navigation("Memberships");
                });

            modelBuilder.Entity("Kolokwium.Models.Organization", b =>
                {
                    b.Navigation("Members");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("Kolokwium.Models.Team", b =>
                {
                    b.Navigation("Files");
                });
#pragma warning restore 612, 618
        }
    }
}
