﻿// <auto-generated />
using EcommerceRazor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceRazor.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.1.23419.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EcommerceRazor.Model.CarPart", b =>
                {
                    b.Property<int>("PartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PartId"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PartName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("PartId");

                    b.ToTable("CarParts");

                    b.HasData(
                        new
                        {
                            PartId = 1,
                            DisplayOrder = 1,
                            Manufacturer = "Nissan",
                            Model = "Maxima",
                            PartName = "Compressor",
                            Year = "2006"
                        },
                        new
                        {
                            PartId = 2,
                            DisplayOrder = 3,
                            Manufacturer = "Ford",
                            Model = "Ecosports",
                            PartName = "Rear Prop Shaft",
                            Year = "2010"
                        },
                        new
                        {
                            PartId = 3,
                            DisplayOrder = 4,
                            Manufacturer = "Hyundai",
                            Model = "Tucson",
                            PartName = "Combination Switch",
                            Year = "2020"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
