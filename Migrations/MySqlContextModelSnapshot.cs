﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace supply_chain_back.Migrations
{
    [DbContext(typeof(MySqlContext))]
    partial class MySqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("ProductAnalisysValueRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("QuotationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("QuotationId");

                    b.ToTable("ProductAnalisysValueRequest");
                });

            modelBuilder.Entity("PurchaseOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Justification")
                        .HasColumnType("longtext");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PurchaseOrder");
                });

            modelBuilder.Entity("Quotation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Quotation");
                });

            modelBuilder.Entity("QuotationFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("QuotationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuotationId");

                    b.ToTable("QuotationFile");
                });

            modelBuilder.Entity("Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("ValueAnalisys", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductAnalisysValueRequestId")
                        .HasColumnType("int");

                    b.Property<int?>("PurchaseOrderId")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductAnalisysValueRequestId");

                    b.HasIndex("PurchaseOrderId");

                    b.HasIndex("SupplierId");

                    b.ToTable("ValueAnalisys");
                });

            modelBuilder.Entity("ProductAnalisysValueRequest", b =>
                {
                    b.HasOne("Product", "Product")
                        .WithMany("ProductAnalisysValueRequests")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Quotation", "Quotation")
                        .WithMany("ProductAnalisysValueRequests")
                        .HasForeignKey("QuotationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Quotation");
                });

            modelBuilder.Entity("QuotationFile", b =>
                {
                    b.HasOne("Quotation", "Quotation")
                        .WithMany("QuotationFile")
                        .HasForeignKey("QuotationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quotation");
                });

            modelBuilder.Entity("ValueAnalisys", b =>
                {
                    b.HasOne("ProductAnalisysValueRequest", "ProductAnalisysValueRequest")
                        .WithMany("ValueAnalisys")
                        .HasForeignKey("ProductAnalisysValueRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PurchaseOrder", "PurchaseOrder")
                        .WithMany("ValueAnalisys")
                        .HasForeignKey("PurchaseOrderId");

                    b.HasOne("Supplier", "Supplier")
                        .WithMany("ValueAnalisys")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductAnalisysValueRequest");

                    b.Navigation("PurchaseOrder");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.Navigation("ProductAnalisysValueRequests");
                });

            modelBuilder.Entity("ProductAnalisysValueRequest", b =>
                {
                    b.Navigation("ValueAnalisys");
                });

            modelBuilder.Entity("PurchaseOrder", b =>
                {
                    b.Navigation("ValueAnalisys");
                });

            modelBuilder.Entity("Quotation", b =>
                {
                    b.Navigation("ProductAnalisysValueRequests");

                    b.Navigation("QuotationFile");
                });

            modelBuilder.Entity("Supplier", b =>
                {
                    b.Navigation("ValueAnalisys");
                });
#pragma warning restore 612, 618
        }
    }
}
