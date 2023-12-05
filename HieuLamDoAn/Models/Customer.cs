using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HieuLamDoAn.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        
        public string? Name { get; set; }
        
        public string? Avatar {  get; set; }
        
       
        
        public string? Comment { get; set; }
 
        public string? Position { get; set; }
    }
}
