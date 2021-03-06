// <auto-generated />
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
    [Migration("20210210204655_SeedLessonControls")]
    partial class SeedLessonControls
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Answer = "Nicola Adams",
                            ControlId = 1,
                            Created = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            LessonGroupId = 2,
                            MapId = 1,
                            Modified = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            Question = "British Female Boxer",
                            XPos = 0,
                            YPos = 0
                        },
                        new
                        {
                            Id = 2,
                            Answer = "Mo Farrah",
                            ControlId = 2,
                            Created = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            LessonGroupId = 2,
                            MapId = 1,
                            Modified = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            Question = "British Long Distance runner and Olympic Champion",
                            XPos = 0,
                            YPos = 0
                        },
                        new
                        {
                            Id = 3,
                            Answer = "Rory McIlroy",
                            ControlId = 3,
                            Created = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            LessonGroupId = 2,
                            MapId = 1,
                            Modified = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            Question = "Golfer from Northern Ireland",
                            XPos = 0,
                            YPos = 0
                        },
                        new
                        {
                            Id = 4,
                            Answer = "Jessica Ennis Hill",
                            ControlId = 4,
                            Created = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            LessonGroupId = 2,
                            MapId = 1,
                            Modified = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            Question = "British Olympic Heptathlon Champion",
                            XPos = 0,
                            YPos = 0
                        },
                        new
                        {
                            Id = 5,
                            Answer = "Joe Root",
                            ControlId = 5,
                            Created = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            LessonGroupId = 2,
                            MapId = 1,
                            Modified = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            Question = "England Cricket Captain",
                            XPos = 0,
                            YPos = 0
                        },
                        new
                        {
                            Id = 6,
                            Answer = "Andy Murray",
                            ControlId = 6,
                            Created = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            LessonGroupId = 2,
                            MapId = 1,
                            Modified = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            Question = "Scottish Tennis Player",
                            XPos = 0,
                            YPos = 0
                        },
                        new
                        {
                            Id = 7,
                            Answer = "Bradley Wiggins",
                            ControlId = 7,
                            Created = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            LessonGroupId = 2,
                            MapId = 1,
                            Modified = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            Question = "Cyclist, Tour de France winner and Olympic Champion",
                            XPos = 0,
                            YPos = 0
                        },
                        new
                        {
                            Id = 8,
                            Answer = "Laura Trott",
                            ControlId = 8,
                            Created = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            LessonGroupId = 2,
                            MapId = 1,
                            Modified = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            Question = "Female Olympic Cycling Champion",
                            XPos = 0,
                            YPos = 0
                        },
                        new
                        {
                            Id = 9,
                            Answer = "Dame Tanni Grey Thompson",
                            ControlId = 9,
                            Created = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            LessonGroupId = 2,
                            MapId = 1,
                            Modified = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            Question = "Ex Paralympic Champion",
                            XPos = 0,
                            YPos = 0
                        },
                        new
                        {
                            Id = 10,
                            Answer = "Chris Hoy",
                            ControlId = 10,
                            Created = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            LessonGroupId = 2,
                            MapId = 1,
                            Modified = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            Question = "British Cycling Champion",
                            XPos = 0,
                            YPos = 0
                        },
                        new
                        {
                            Id = 11,
                            Answer = "Jonny Wilkinson",
                            ControlId = 11,
                            Created = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            LessonGroupId = 2,
                            MapId = 1,
                            Modified = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            Question = "Ex England Rugby Star",
                            XPos = 0,
                            YPos = 0
                        },
                        new
                        {
                            Id = 12,
                            Answer = "Harry Kane",
                            ControlId = 12,
                            Created = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            LessonGroupId = 2,
                            MapId = 1,
                            Modified = new DateTime(2021, 2, 10, 20, 46, 55, 230, DateTimeKind.Local).AddTicks(8011),
                            Question = "English Football Player",
                            XPos = 0,
                            YPos = 0
                        });
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
                });
#pragma warning restore 612, 618
        }
    }
}
