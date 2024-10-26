using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBoutique.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 1)]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }

        public string Category { get; set; } = string.Empty;

        public string Rating { get; set; } = string.Empty;
    }
}
