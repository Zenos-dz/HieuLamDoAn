using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HieuLamDoAn.Models
{
    [Table("TypeFood")]
    public class TypeFood
    {
        [Key]
        public int TypeFoodID { get; set; }
        public string? Attribute { get; set; }

        public string? Name { get; set; }

       public List<FoodMenu>? FoodMenus { get; set; }

    }

}