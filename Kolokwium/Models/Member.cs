using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium.Models
{
    public class Member
    {
        [Required]
        [Key]
        public int MemberID { get; set; }
        [Required]
        public int OrganizationID { get; set; }
        [Required]
        [MaxLength(20)]
        public string MemberName { get; set; }
        [Required]
        [MaxLength(50)]
        public string MemberSurname { get; set; }
        [MaxLength(20)]
        public string MemberNickName { get; set; }

        [ForeignKey("OrganizationID")]
        public virtual Organization Organization { get; set; }
        public ICollection<Membership> Memberships { get; set; }
    }
}
