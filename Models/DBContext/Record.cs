using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DBContext
{
    public class Record
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }
        [ForeignKey("Phone")]
        public int PhoneId { get; set; }
        [ForeignKey("AppUser")]
        public int? Id { get; set; }
        [ForeignKey("Sale")]
        public int? SaleId { get; set; }
        public double FinalPrice { get; set; }
        public DateTime SoldDate { get; set; }

        public Sale? Sale { get; set; }
        public Phone? Phone { get; set; }
        public AppUser? AppUser { get; set; }
       
    }
}
