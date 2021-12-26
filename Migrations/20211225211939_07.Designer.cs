﻿// <auto-generated />
using System;
using GestionProduit.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestionProduit.Migrations
{
    [DbContext(typeof(GPContext))]
    [Migration("20211225211939_07")]
    partial class _07
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestionProduit.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MyName");

                    b.HasKey("CategoryID");

                    b.ToTable("MyCategories");
                });

            modelBuilder.Entity("GestionProduit.Models.Client", b =>
                {
                    b.Property<int>("CIN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CIN");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("GestionProduit.Models.Facture", b =>
                {
                    b.Property<int>("ClientFk")
                        .HasColumnType("int");

                    b.Property<int>("ProductFk")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAchat")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ClientCIN")
                        .HasColumnType("int");

                    b.Property<double>("Prix")
                        .HasColumnType("float");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ClientFk", "ProductFk", "DateAchat");

                    b.HasIndex("ClientCIN");

                    b.HasIndex("ProductId");

                    b.ToTable("Factures");
                });

            modelBuilder.Entity("GestionProduit.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int?>("CatgoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateProd")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("MyName");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<short>("Quantity")
                        .HasColumnType("smallint");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("GestionProduit.Models.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("ProductProvider", b =>
                {
                    b.Property<int>("ProductsProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProvidersId")
                        .HasColumnType("int");

                    b.HasKey("ProductsProductId", "ProvidersId");

                    b.HasIndex("ProvidersId");

                    b.ToTable("Providings");
                });

            modelBuilder.Entity("GestionProduit.Models.Biological", b =>
                {
                    b.HasBaseType("GestionProduit.Models.Product");

                    b.Property<string>("Herbs")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Biologicals");
                });

            modelBuilder.Entity("GestionProduit.Models.Chemical", b =>
                {
                    b.HasBaseType("GestionProduit.Models.Product");

                    b.Property<string>("LabName")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Chemicals");
                });

            modelBuilder.Entity("GestionProduit.Models.Facture", b =>
                {
                    b.HasOne("GestionProduit.Models.Client", "Client")
                        .WithMany("Factures")
                        .HasForeignKey("ClientCIN");

                    b.HasOne("GestionProduit.Models.Product", "Product")
                        .WithMany("Factures")
                        .HasForeignKey("ProductId");

                    b.Navigation("Client");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("GestionProduit.Models.Product", b =>
                {
                    b.HasOne("GestionProduit.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ProductProvider", b =>
                {
                    b.HasOne("GestionProduit.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestionProduit.Models.Provider", null)
                        .WithMany()
                        .HasForeignKey("ProvidersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GestionProduit.Models.Biological", b =>
                {
                    b.HasOne("GestionProduit.Models.Product", null)
                        .WithOne()
                        .HasForeignKey("GestionProduit.Models.Biological", "ProductId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GestionProduit.Models.Chemical", b =>
                {
                    b.HasOne("GestionProduit.Models.Product", null)
                        .WithOne()
                        .HasForeignKey("GestionProduit.Models.Chemical", "ProductId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.OwnsOne("GestionProduit.Models.Address", "Address", b1 =>
                        {
                            b1.Property<int>("ChemicalProductId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("MyCity");

                            b1.Property<string>("StreetAddress")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)")
                                .HasColumnName("MyAddress");

                            b1.HasKey("ChemicalProductId");

                            b1.ToTable("Chemicals");

                            b1.WithOwner()
                                .HasForeignKey("ChemicalProductId");
                        });

                    b.Navigation("Address");
                });

            modelBuilder.Entity("GestionProduit.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("GestionProduit.Models.Client", b =>
                {
                    b.Navigation("Factures");
                });

            modelBuilder.Entity("GestionProduit.Models.Product", b =>
                {
                    b.Navigation("Factures");
                });
#pragma warning restore 612, 618
        }
    }
}
