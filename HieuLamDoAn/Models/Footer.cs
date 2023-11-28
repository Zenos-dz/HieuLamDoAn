using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HieuLamDoAn.Models
{
	[Table("Footer")]
	public class Footer
	{
		[Key]
		public int FooterID { get; set; }
		public string? Company { get; set; }
		public string? Contact {  get; set; }
		public string? Opening {  get; set; }
		public string? Newsletter { get; set; }
		public string? Infomation { get; set; }
		public string? TimeOpen { get; set;}
		public string? IconContact { get; set; }
        public string? IconSocial { get; set; }
        public string? LinkCompany { get; set; }
        public string? LinkSM { get; set; }
    }
}
