﻿// <auto-generated />
using Azurepeakswebcomic.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace Azurepeakswebcomic.Migrations
{
    [DbContext(typeof(ComicDbContext))]
    [Migration("20171103201835_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Azurepeakswebcomic.Models.Entities.Comic", b =>
                {
                    b.Property<int>("ComicId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Date");

                    b.Property<string>("Imgurl");

                    b.Property<string>("Name");

                    b.HasKey("ComicId");

                    b.ToTable("Comics");
                });
#pragma warning restore 612, 618
        }
    }
}
