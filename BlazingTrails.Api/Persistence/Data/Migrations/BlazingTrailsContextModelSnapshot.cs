﻿// <auto-generated />
using BlazingTrails.Api.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazingTrails.Api.Persistence.Data.Migrations
{
    [DbContext(typeof(BlazingTrailsContext))]
    partial class BlazingTrailsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0-rc.2.21480.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazingTrails.Api.Persistence.Entities.RouteInstruction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stage")
                        .HasColumnType("int");

                    b.Property<int>("TrailId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrailId");

                    b.ToTable("RouteInstructions");
                });

            modelBuilder.Entity("BlazingTrails.Api.Persistence.Entities.Trail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TimeInMinutes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Trails");
                });

            modelBuilder.Entity("BlazingTrails.Api.Persistence.Entities.RouteInstruction", b =>
                {
                    b.HasOne("BlazingTrails.Api.Persistence.Entities.Trail", "Trail")
                        .WithMany("Route")
                        .HasForeignKey("TrailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trail");
                });

            modelBuilder.Entity("BlazingTrails.Api.Persistence.Entities.Trail", b =>
                {
                    b.Navigation("Route");
                });
#pragma warning restore 612, 618
        }
    }
}
