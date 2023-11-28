using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HieuLamDoAn.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string? PassWord {  get; set; }
        public string? Name { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Avatar {  get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Comment { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Position { get; set; }
    }
}
