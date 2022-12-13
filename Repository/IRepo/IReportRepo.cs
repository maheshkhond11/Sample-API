using DTOs;
using Models.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepo
{
    public interface IReportRepo
    {
        public IQueryable<TempDTO> GenerateMonthlyReport(DateTime fromDate, DateTime toDate);
        public IQueryable<SalesReportDTO> GenerateMonthlyBranWiseReport(string BrandTemp, DateTime fromDate, DateTime toDate);
    }  
}
