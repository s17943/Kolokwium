using Microsoft.EntityFrameworkCore;
using Kolokwium.Models;
using File = Kolokwium.Models.File;

namespace Kolokwium.DataAccess
{
    public class PjatkDbContext : DbContext
    {
       
        public DbSet<Models.File> File { get; set; }
        public DbSet<Models.Team> Team { get; set; }
        public DbSet<Models.Member> Member { get; set; }
        public DbSet<Models.Membership> Membership { get; set; }
        public DbSet<Models.Organization> Organization { get; set; }
        public PjatkDbContext()
        {

        }

        public PjatkDbContext(DbContextOptions options) : base(options)
        {

        }
     

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<File>(p =>
            {
                p.HasData(
                    new File { FileID = 1, TeamID = 1, FileName = "Name1", FileExtension = ".zip"  }
                    );
                p.HasData(
                    new File { FileID = 2, TeamID = 2, FileName = "Name2", FileExtension = ".zip" }
                    );
            });

            modelbuilder.Entity<Team>(t =>
            {
                t.HasData(new Team { TeamID = 1, TeamName = "ABC", TeamDescription = "AAAAAAAAAA", OrganizationID = 1 });
                t.HasData(new Team { TeamID = 2, TeamName = "ADC", TeamDescription = "BBBBBBB", OrganizationID = 2 });
            });

            modelbuilder.Entity<Organization>(O =>
            {
                O.HasData(new Organization { OrganizationID = 1, OrganizationName = "Organization1", OrganizationDomain = "Home" });
                O.HasData(new Organization { OrganizationID = 2, OrganizationName = "Organization2", OrganizationDomain = "Away" });
            });

            modelbuilder.Entity<Member>(m =>
            {
                m.HasData(new Models.Member { MemberID = 1, MemberName = "Andrzej", MemberSurname = "Kowalski", MemberNickName = "AndrzejKowalski" });
                m.HasData(new Models.Member { MemberID = 2, MemberName = "Maciej", MemberSurname = "Nowak", MemberNickName = "Nowak" });
            });
            


        }

    }




}
