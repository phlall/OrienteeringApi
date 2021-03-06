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
    [Migration("20210222131622_LessonGroup_Maps_relation")]
    partial class LessonGroup_Maps_relation
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

                    b.HasIndex("QAId");

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

                    b.Property<int>("MapId")
                        .HasColumnType("integer");

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

                    b.HasIndex("MapId");

                    b.HasIndex("SchoolId");

                    b.ToTable("LessonGroups");
                });

            modelBuilder.Entity("OrienteeringApi.Database.LessonGroupSession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Completed")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("LessonGroupId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("LessonGroupId");

                    b.ToTable("LessonGroupSessions");
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

            modelBuilder.Entity("OrienteeringApi.Database.Pupil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int>("SchoolId")
                        .HasColumnType("integer");

                    b.Property<string>("YearGroup")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pupils");
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

            modelBuilder.Entity("OrienteeringApi.Database.SessionPupil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CompletedIn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("LessonGroupSessionId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PupilAnswer")
                        .HasColumnType("text");

                    b.Property<int>("PupilId")
                        .HasColumnType("integer");

                    b.Property<int>("QAId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LessonGroupSessionId");

                    b.HasIndex("PupilId");

                    b.HasIndex("QAId");

                    b.ToTable("SessionPupils");
                });

            modelBuilder.Entity("OrienteeringApi.Database.LessonControl", b =>
                {
                    b.HasOne("OrienteeringApi.Database.LessonGroup", "LessonGroup")
                        .WithMany("LessonControls")
                        .HasForeignKey("LessonGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrienteeringApi.Database.QA", "QuestionAnswer")
                        .WithMany()
                        .HasForeignKey("QAId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LessonGroup");

                    b.Navigation("QuestionAnswer");
                });

            modelBuilder.Entity("OrienteeringApi.Database.LessonGroup", b =>
                {
                    b.HasOne("OrienteeringApi.Database.LessonSubject", "LessonSubject")
                        .WithMany()
                        .HasForeignKey("LessonSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrienteeringApi.Database.Map", "Map")
                        .WithMany("LessonGroups")
                        .HasForeignKey("MapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrienteeringApi.Database.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LessonSubject");

                    b.Navigation("Map");

                    b.Navigation("School");
                });

            modelBuilder.Entity("OrienteeringApi.Database.LessonGroupSession", b =>
                {
                    b.HasOne("OrienteeringApi.Database.LessonGroup", "LessonGroup")
                        .WithMany("LessonGroupSessions")
                        .HasForeignKey("LessonGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LessonGroup");
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

            modelBuilder.Entity("OrienteeringApi.Database.SessionPupil", b =>
                {
                    b.HasOne("OrienteeringApi.Database.LessonGroupSession", "LessonGroupSession")
                        .WithMany()
                        .HasForeignKey("LessonGroupSessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrienteeringApi.Database.Pupil", "Pupil")
                        .WithMany()
                        .HasForeignKey("PupilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrienteeringApi.Database.QA", "QA")
                        .WithMany()
                        .HasForeignKey("QAId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LessonGroupSession");

                    b.Navigation("Pupil");

                    b.Navigation("QA");
                });

            modelBuilder.Entity("OrienteeringApi.Database.LessonGroup", b =>
                {
                    b.Navigation("LessonControls");

                    b.Navigation("LessonGroupSessions");
                });

            modelBuilder.Entity("OrienteeringApi.Database.Map", b =>
                {
                    b.Navigation("LessonGroups");
                });
#pragma warning restore 612, 618
        }
    }
}
