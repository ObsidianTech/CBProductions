﻿// <auto-generated />
using System;
using CBPVideoAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CBPVideoAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190228031624_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CBPVideoAPI.Models.Video", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("FeatureFilm");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UploadDate");

                    b.Property<string>("filename");

                    b.Property<string>("filepath");

                    b.HasKey("ID");

                    b.ToTable("Videos");
                });
#pragma warning restore 612, 618
        }
    }
}