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
    [Migration("20210222122747_add-migation QALessonCntrol")]
    partial class addmigationQALessonCntrol
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

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("LessonGroupId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("QAId")
                        .HasColumnType("integer");

                    b.Property<int>("XPos")
                        .HasColumnType("integer");

                    b.Property<int>("YPos")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LessonGroupId");

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

                    b.Property<int>("SchoolId")
                        .HasColumnType("integer");

                    b.Property<bool>("Shared")
                        .HasColumnType("boolean");

                    b.Property<string>("Warmup")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("LessonSubjectId");

                    b.HasIndex("SchoolId");

                    b.ToTable("LessonGroups");
                });

            modelBuilder.Entity("OrienteeringApi.Database.LessonSubject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPremium")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsShared")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("ThemeImage")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

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
                });

            modelBuilder.Entity("OrienteeringApi.Database.QA", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LessonSubjectId")
                        .HasColumnType("integer");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("LessonSubjectId");

                    b.ToTable("QAs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Answer = "Scotland",
                            LessonSubjectId = 3,
                            Question = "Flag of Scotland"
                        },
                        new
                        {
                            Id = 2,
                            Answer = "Germany",
                            LessonSubjectId = 3,
                            Question = "Flag of Germany"
                        },
                        new
                        {
                            Id = 3,
                            Answer = "Ireland",
                            LessonSubjectId = 3,
                            Question = "Flag of Ireland"
                        });
                });

            modelBuilder.Entity("OrienteeringApi.Database.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Contact")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("OrienteeringApi.Database.LessonControl", b =>
                {
                    b.HasOne("OrienteeringApi.Database.LessonGroup", "LessonGroup")
                        .WithMany("LessonControls")
                        .HasForeignKey("LessonGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LessonGroup");
                });

            modelBuilder.Entity("OrienteeringApi.Database.LessonGroup", b =>
                {
                    b.HasOne("OrienteeringApi.Database.LessonSubject", "LessonSubject")
                        .WithMany()
                        .HasForeignKey("LessonSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrienteeringApi.Database.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LessonSubject");

                    b.Navigation("School");
                });

            modelBuilder.Entity("OrienteeringApi.Database.QA", b =>
                {
                    b.HasOne("OrienteeringApi.Database.LessonSubject", "LessonSubject")
                        .WithMany()
                        .HasForeignKey("LessonSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LessonSubject");
                });

            modelBuilder.Entity("OrienteeringApi.Database.LessonGroup", b =>
                {
                    b.Navigation("LessonControls");
                });
#pragma warning restore 612, 618
        }
    }
}
