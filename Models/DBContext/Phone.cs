using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DBContext
{
    public class Phone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PhoneId { get; set; }
        public string PhoneName { get; set; }
        [ForeignKey("Brand")]
        public int? BrandId { get; set; }
        public double PhonePrice { get; set; }

        public Brand? Brand { get; set; }
        public ICollection<Record>? Record { get; set; }
    }
}
