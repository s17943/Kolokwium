using Kolokwium.DTO;

namespace kolokwium_poprawa.Services
{
    public interface IDbService
    {
        async Task<Team> GetTeamById(int teamId);
    }
}
