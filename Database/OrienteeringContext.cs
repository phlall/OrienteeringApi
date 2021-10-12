using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public class OrienteeringContext : DbContext
    {
        public OrienteeringContext(DbContextOptions<OrienteeringContext> options) : base(options)
        { }

        public OrienteeringContext() { }
        public DbSet<Control> Controls { get; set; }
        public DbSet<LessonGroup> LessonGroups { get; set; }
        public DbSet<LessonControl> LessonControls { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<QA> QAs { get; set; }
        public DbSet<MapNode> MapNodes { get; set; }
        public DbSet<MapImage> MapImages { get; set; }
        public DbSet<LessonGroupSession> LessonGroupSessions { get; set; }
        public DbSet<LessonSubject> LessonSubjects { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<SessionPupil> SessionPupils { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var date = DateTime.Now;
            //modelBuilder.Entity<Control>().HasData(
            //       new Control { Id = 1, Image = "image1", Description = "A very well hidden control", Created = date, Modified = date },
            //       new Control { Id = 2, Image = "image2", Description = "A well placed control", Created = date, Modified = date.AddMinutes(10) },
            //       new Control { Id = 3, Image = "image3", Description = "Behind the bike rack", Created = date, Modified = date.AddMinutes(20) },
            //       new Control { Id = 4, Image = "image4", Description = "On a wall", Created = date, Modified = date.AddMinutes(30) },
            //       new Control { Id = 5, Image = "image5", Description = "Under a hat", Created = date, Modified = date.AddMinutes(40) },
            //       new Control { Id = 6, Image = "image6", Description = "In a room", Created = date, Modified = date.AddMinutes(50) },
            //       new Control { Id = 7, Image = "image7", Description = "On the rrof", Created = date, Modified = date.AddMinutes(60) },
            //       new Control { Id = 8, Image = "image8", Description = "Behind the curtain", Created = date, Modified = date.AddMinutes(70) },
            //       new Control { Id = 9, Image = "image9", Description = "Behind you!", Created = date, Modified = date.AddMinutes(80) },
            //       new Control { Id = 10, Image = "image10", Description = "In pla", Created = date, Modified = date.AddMinutes(90) }
            //);
            //modelBuilder.Entity<LessonSubject>().HasData(
            //     new LessonSubject { Id = 1, Name = "Decode a Message", },
            //     new LessonSubject { Id = 2, Name = "Find The Sport Star" },
            //     new LessonSubject { Id = 3, Name = "Sporting Anagrams" },
            //     new LessonSubject { Id = 4, Name = "Fitness Circuit" },
            //     new LessonSubject { Id = 5, Name = "Flags" },
            //     new LessonSubject { Id = 6, Name = "Maths" });

            //modelBuilder.Entity<LessonGroup>().HasData(
            //         new LessonGroup { Id = 1, AgeGroup = "EYFS", LessonSubjectId = 1, Shared = true, Equipment="Wheelbarrow", Created = date, Modified = date },
            //         new LessonGroup { Id = 2, AgeGroup = "KS1", LessonSubjectId = 2, Shared = true, Equipment = "Tweezers", Created = date, Modified = date },
            //         new LessonGroup { Id = 3, AgeGroup = "LKS2", LessonSubjectId = 3, Shared = true, Equipment = "Football, Socks, Tattoos", Created = date, Modified = date },
            //         new LessonGroup { Id = 4, AgeGroup = "UKS2", LessonSubjectId = 4, Shared = true, Equipment = "Scooter", Created = date, Modified = date }


            //  );

            //modelBuilder.Entity<Map>().HasData(
            //     new Map { Id = 1, Image = "PickhurstJunior.png", Created = date, Modified = date },
            //     new Map { Id = 2, Image = "Primary1.png", Created = date, Modified = date },
            //     new Map { Id = 3, Image = "Primary2.png", Created = date, Modified = date });

            //modelBuilder.Entity<LessonControl>().HasData(
            //    new LessonControl { Id = 1, LessonGroupId = 2, ControlId = 1, MapId = 1, YPos = 0, XPos = 0, Answer = "Nicola Adams", Question = "British Female Boxer", Created = date, Modified = date },
            //    new LessonControl { Id = 2, LessonGroupId = 2, ControlId = 2, MapId = 1, YPos = 0, XPos = 0, Answer = "Mo Farrah", Question = "British Long Distance runner and Olympic Champion", Created = date, Modified = date },
            //    new LessonControl { Id = 3, LessonGroupId = 2, ControlId = 3, MapId = 1, YPos = 0, XPos = 0, Answer = "Rory McIlroy", Question = "Golfer from Northern Ireland", Created = date, Modified = date },
            //    new LessonControl { Id = 4, LessonGroupId = 2, ControlId = 4, MapId = 1, YPos = 0, XPos = 0, Answer = "Jessica Ennis Hill", Question = "British Olympic Heptathlon Champion", Created = date, Modified = date },
            //    new LessonControl { Id = 5, LessonGroupId = 2, ControlId = 5, MapId = 1, YPos = 0, XPos = 0, Answer = "Joe Root", Question = "England Cricket Captain", Created = date, Modified = date },
            //    new LessonControl { Id = 6, LessonGroupId = 2, ControlId = 6, MapId = 1, YPos = 0, XPos = 0, Answer = "Andy Murray", Question = "Scottish Tennis Player", Created = date, Modified = date },
            //    new LessonControl { Id = 7, LessonGroupId = 2, ControlId = 7, MapId = 1, YPos = 0, XPos = 0, Answer = "Bradley Wiggins", Question = "Cyclist, Tour de France winner and Olympic Champion", Created = date, Modified = date },
            //    new LessonControl { Id = 8, LessonGroupId = 2, ControlId = 8, MapId = 1, YPos = 0, XPos = 0, Answer = "Laura Trott", Question = "Female Olympic Cycling Champion", Created = date, Modified = date },
            //    new LessonControl { Id = 9, LessonGroupId = 2, ControlId = 9, MapId = 1, YPos = 0, XPos = 0, Answer = "Dame Tanni Grey Thompson", Question = "Ex Paralympic Champion", Created = date, Modified = date },
            //    new LessonControl { Id = 10, LessonGroupId = 2, ControlId = 10, MapId = 1, YPos = 0, XPos = 0, Answer = "Chris Hoy", Question = "British Cycling Champion", Created = date, Modified = date },
            //    new LessonControl { Id = 11, LessonGroupId = 2, ControlId = 11, MapId = 1, YPos = 0, XPos = 0, Answer = "Jonny Wilkinson", Question = "Ex England Rugby Star", Created = date, Modified = date },
            //    new LessonControl { Id = 12, LessonGroupId = 2, ControlId = 12, MapId = 1, YPos = 0, XPos = 0, Answer = "Harry Kane", Question = "English Football Player", Created = date, Modified = date }
            //    );
            //modelBuilder.Entity<School>().HasData(
            //     new School { Id = 1, Name = "St Trinians", Address = "1 Acatia Crescent", Postcode = "W99 9XX", Contact = "Miss Hilda Han-Hindenberg", Type = "Primary", Created = date, Modified = date }
            //     );

            //modelBuilder.Entity<QA>().HasData(
            //         new QA { Id = 1, LessonSubjectId = 3, Answer = "Scotland", Question ="Flag of Scotland"},
            //          new QA { Id = 2, LessonSubjectId = 3, Answer = "Germany", Question = "Flag of Germany" },
            //           new QA { Id = 3, LessonSubjectId = 3, Answer = "Ireland", Question = "Flag of Ireland" }




            //  );
        }
    }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseNpgsql("Host=ec2-108-128-104-50.eu-west-1.compute.amazonaws.com;Database=d4edukud6ealii;Username=ddcdjyvraiiace;Password=437b7438011bcf9e5cdc3c62e00af44f0e76d04c844e50bee8527a54589c6f07");

    
}
