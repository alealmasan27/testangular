﻿// <auto-generated />
using EFTest;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFTest.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("EFTest.Domain.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("EFTest.Domain.Shareholder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shareholders");
                });

            modelBuilder.Entity("EFTest.Domain.ShareholderToCompany", b =>
                {
                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("ShareholderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CompanyId", "ShareholderId");

                    b.HasIndex("ShareholderId");

                    b.ToTable("ShareholdersToCompanies");
                });

            modelBuilder.Entity("EFTest.Domain.ShareholderToCompany", b =>
                {
                    b.HasOne("EFTest.Domain.Company", "Company")
                        .WithMany("ShareholderToCompanies")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFTest.Domain.Shareholder", "Shareholder")
                        .WithMany("ShareholderToCompanies")
                        .HasForeignKey("ShareholderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Shareholder");
                });

            modelBuilder.Entity("EFTest.Domain.Company", b =>
                {
                    b.Navigation("ShareholderToCompanies");
                });

            modelBuilder.Entity("EFTest.Domain.Shareholder", b =>
                {
                    b.Navigation("ShareholderToCompanies");
                });
#pragma warning restore 612, 618
        }
    }
}
