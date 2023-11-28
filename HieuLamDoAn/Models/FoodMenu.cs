using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HieuLamDoAn.Models
{
    [Table("FoodMenu")]
    public class FoodMenu
    {
        [Key]
        public int FoodID { get; set; }
        [ForeignKey("TypeFood")]
        public int TypeFoodID { get; set; }
        public string? Title { get; set; }

        public string? Contents { get; set; }

        public string? Img { get; set; }

        public string? Cost { get; set; }

        public TypeFood? TypeFood { get; set; }

    }

}
