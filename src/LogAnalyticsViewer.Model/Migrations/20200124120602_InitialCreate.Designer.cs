﻿// <auto-generated />
using LogAnalyticsViewer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LogAnalyticsViewer.Model.Migrations
{
    [DbContext(typeof(LAVDataContext))]
    [Migration("20200124120602_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LogAnalyticsViewer.Model.Entities.DumpSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DelayBetweenDumpsInMinutes")
                        .HasColumnType("int");

                    b.Property<int>("DumpOverlapInMinutes")
                        .HasColumnType("int");

                    b.Property<int>("DumpSizeInMinutes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DumpSettings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DelayBetweenDumpsInMinutes = 15,
                            DumpOverlapInMinutes = 5,
                            DumpSizeInMinutes = 30
                        });
                });

            modelBuilder.Entity("LogAnalyticsViewer.Model.Entities.LogAnalyticsSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientSecret")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Domain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkspaceId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LogAnalyticsSettings");
                });

            modelBuilder.Entity("LogAnalyticsViewer.Model.Entities.Query", b =>
                {
                    b.Property<int>("QueryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QueryText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QueryId");

                    b.ToTable("Queries");
                });
#pragma warning restore 612, 618
        }
    }
}
