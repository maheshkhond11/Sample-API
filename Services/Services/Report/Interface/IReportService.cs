using DTOs;
using Models.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Report.Interface
{
    public interface IReportService
    {
        public IEnumerable<SalesReportDTO> GenerateMonthlyReport(DateTime fromDate, DateTime toDate);
    }
}
