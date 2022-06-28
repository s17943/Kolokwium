using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium.Models
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public int OrganizationID { get; set; }
        [MaxLength(50)]
        [Required]
        public string TeamName { get; set; }
        [MaxLength(500)]
        public string TeamDescription { get; set; }
        [ForeignKey("OrganizationID")]
        public virtual Organization Organization { get; set; }
        public ICollection<File> Files { get; set; }
    }
}
