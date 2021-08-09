﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OrienteeringApi.Database;

namespace OrienteeringApi.Migrations
{
    [DbContext(typeof(OrienteeringContext))]
    [Migration("20210210164528_SeedMaps")]
    partial class SeedMaps
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("OrienteeringApi.Database.Control", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Controls");
                });

            modelBuilder.Entity("OrienteeringApi.Database.LessonControl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("text");

                    b.Property<int>("ControlId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("LessonGroupId")
                        .HasColumnType("integer");

                    b.Property<int>("MapId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Question")
                        .HasColumnType("text");

                    b.Property<int>("XPos")
                        .HasColumnType("integer");

                    b.Property<int>("YPos")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("LessonControls");
                });

            modelBuilder.Entity("OrienteeringApi.Database.LessonGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AgeGroup")
                        .HasColumnType("text");

                    b.Property<string>("Conclusion")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Equipment")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("GameBasedLearning")
                        .HasColumnType("text");

                    b.Property<string>("Intro")
                        .HasColumnType("text");

                    b.Property<int>("LessonSubjectId")
                        .HasColumnType("integer");

                    b.Property<string>("Location")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("MainSession")
                        .HasColumnType("text");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Shared")
                        .HasColumnType("boolean");

                    b.Property<string>("Warmup")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("LessonGroups");
                });

            modelBuilder.Entity("OrienteeringApi.Database.LessonSubject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("LessonSubjects");
                });

            modelBuilder.Entity("OrienteeringApi.Database.Map", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Maps");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2021, 2, 10, 16, 45, 27, 774, DateTimeKind.Local).AddTicks(1153),
                            Image = "PickhurstJunior.png",
                            Modified = new DateTime(2021, 2, 10, 16, 45, 27, 774, DateTimeKind.Local).AddTicks(1153)
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2021, 2, 10, 16, 45, 27, 774, DateTimeKind.Local).AddTicks(1153),
                            Image = "Primary1.png",
                            Modified = new DateTime(2021, 2, 10, 16, 45, 27, 774, DateTimeKind.Local).AddTicks(1153)
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2021, 2, 10, 16, 45, 27, 774, DateTimeKind.Local).AddTicks(1153),
                            Image = "Primary2.png",
                            Modified = new DateTime(2021, 2, 10, 16, 45, 27, 774, DateTimeKind.Local).AddTicks(1153)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
