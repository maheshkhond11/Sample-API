using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models.DBContext
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SaleId { get; set; }
        public string? SaleName { get; set; }
        public double TotalDiscount { get; set; }
        public ICollection<Record>? Record { get; set; }

    }
}
