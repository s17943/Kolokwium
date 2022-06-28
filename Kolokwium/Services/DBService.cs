using Kolokwium.Models;
using Kolokwium.DTO;
using Microsoft.EntityFrameworkCore;
using Kolokwium.DataAccess;

namespace kolokwium_poprawa.Services
{
    public class DbService : IDbService
    {
        private readonly PjatkDbContext _mainDbContext;

        public DbService(PjatkDbContext mainDbContext)
        {
            _mainDbContext = mainDbContext;
        }

        public async Task<Team> GetTeamById(int teamId)
        {
            var team = await _mainDbContext.Team
                .Where(e => e.TeamID == teamId)
                .Select(e => new Team
                {
                    TeamName = e.TeamName,
                    Organization = e.Organization
                }).FirstOrDefaultAsync();

 

    }

        Task<Team> IDbService.GetTeamById(int teamId)
        {
            throw new NotImplementedException();
        }
    }
