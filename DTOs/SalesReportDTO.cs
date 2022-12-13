using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class SalesReportDTO
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int UnitsSold { get; set; }
        public double TotalAmount { get; set; }
    }
}
