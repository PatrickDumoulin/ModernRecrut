﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModernRecrut.Postulation.API.Data;

#nullable disable

namespace ModernRecrut.Postulation.API.Migrations
{
    [DbContext(typeof(PostulationsContext))]
    [Migration("20231207001059_AjoutNote")]
    partial class AjoutNote
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("ModernRecrut.Postulation.API.Models.NoteDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IdCandidat")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomEmeteur")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("NoteDetail");
                });

            modelBuilder.Entity("ModernRecrut.Postulation.API.Models.PostulationDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateDisponibilite")
                        .HasColumnType("TEXT");

                    b.Property<string>("IdCandidat")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("OffreDEmploiId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("PretentionSalariale")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PostulationDetail");
                });
#pragma warning restore 612, 618
        }
    }
}