﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WordToPdfExporter.Infrastructure.Data;

#nullable disable

namespace WordToPdfExporter.Infrastructure.Data.Migrations
{
    [DbContext(typeof(WordToPdfExporterContext))]
    [Migration("20241219154210_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.11");

            modelBuilder.Entity("WordToPdfExporter.Core.Exporting.CurrentDocumentExport", b =>
                {
                    b.Property<int>("CurrentDocumentExportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DocumentExportRequestId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ProcessedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("RequestBody")
                        .HasColumnType("TEXT");

                    b.Property<string>("RequestHost")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RequestedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("CurrentDocumentExportId");

                    b.HasIndex("DocumentExportRequestId");

                    b.ToTable("CurrentDocumentExports");
                });

            modelBuilder.Entity("WordToPdfExporter.Core.Exporting.DocumentExport", b =>
                {
                    b.Property<int>("DocumentExportRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ProcessedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("RequestBody")
                        .HasColumnType("TEXT");

                    b.Property<string>("RequestHost")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RequestedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("DocumentExportRequestId");

                    b.ToTable("DocumentExports");
                });

            modelBuilder.Entity("WordToPdfExporter.Core.Exporting.CurrentDocumentExport", b =>
                {
                    b.HasOne("WordToPdfExporter.Core.Exporting.DocumentExport", "DocumentExportRequest")
                        .WithMany()
                        .HasForeignKey("DocumentExportRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DocumentExportRequest");
                });
#pragma warning restore 612, 618
        }
    }
}