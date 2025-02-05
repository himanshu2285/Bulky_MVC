using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Category Name")]
        public required string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100)]
        public int DisplayOrder { get; set; }
    }
}
