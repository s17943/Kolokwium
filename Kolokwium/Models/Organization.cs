using System.ComponentModel.DataAnnotations;

namespace Kolokwium.Models
{
    public class Organization
    {
        public int OrganizationID { get; set; }
        [Required]
        [MaxLength(100)]

        public string OrganizationName { get; set; }
        [Required]
        [MaxLength(50)]
        public string OrganizationDomain { get; set; }

        public ICollection<Team> Teams { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}
