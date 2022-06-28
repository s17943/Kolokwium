using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium.Models
{
    public class Membership
    {
        [Required]
        [Key]
        public int MemberID { get; set; }
        
        [Required]
        public int TeamID { get; set; }
        [Required]
        public DateTime MembershipDate { get; set; }
        [ForeignKey("MemberID")]
        public virtual Member Member { get; set; }

    }
}
