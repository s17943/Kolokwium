using Kolokwium.Models;

namespace Kolokwium.DTO
{
    public class DTO
    {
        public string TeamName { get; set; }
        public string OrganizationName { get; set; }
        public ICollection<Member> Members { get; set; }
        public string? TeamDescription { get; set; }
    }
}
