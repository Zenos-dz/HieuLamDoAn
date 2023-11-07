using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HieuLamDoAn.Models
{
    [Table("TeamMembers")]
    public class TeamMembers
    {
        [Key]
        public int MemberID { get; set; }
        public string? MemberName { get; set; }
        public string? Designation {  get; set; }
        public string? Image {  get; set; }
        public string? FbUrl { get; set; }
        public string? TwUrl { get; set;}
        public string? IgUrl { get; set;}
    }
}
