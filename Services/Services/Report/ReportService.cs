using DTOs;
using Models.DBContext;
using Repository.IRepo;
using Services.Services.Report.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Report
{
    public class ReportService : IReportService
    {
        private readonly IBrandsRepo brandsRepo;
        private readonly IPhonesRepo phonesRepo;
        private readonly ISalesRepo salesRepo;
        private readonly IRecordsRepo recordsRepo;
        public ReportService(IBrandsRepo _brandsRepo, IPhonesRepo _phonesRepo, ISalesRepo _salesRepo, IRecordsRepo _recordsRepo)
        {
            brandsRepo = _brandsRepo;
            phonesRepo = _phonesRepo;
            salesRepo = _salesRepo;
            recordsRepo = _recordsRepo;
        }
        public IEnumerable<SalesReportDTO> GenerateMonthlyReport(DateTime fromDate, DateTime toDate)
        {
            var records = recordsRepo.GetAllRecords();

            var rc = records.Where(rec => 
            rec.SoldDate > fromDate && rec.SoldDate < toDate).ToList();

            //var rp = records.Where(rec => rec.SoldDate > fromDate && rec.SoldDate < toDate).
            //    .Select(r => new SalesReportDTO
            //    {
            //        Brand = r.
            //    }
            //    ).ToList<SalesReportDTO>;

            var phones = phonesRepo.GetAllPhones().ToList();
            SalesReportDTO[] temp = new SalesReportDTO[phones.Count];
            for (int i = 0; i < phones.Count; i++)
                temp[i] = new SalesReportDTO();
            for (int i = 0; i < phones.Count; i++)
            {
                temp[i].Model = phones[i].PhoneName;
            }
            for (int i = 0; i < rc.Count; i++)
            {
                for(int j = 0; j < phones.Count; j++)
                if (!(rc[i].Phone.PhoneName.Equals(temp[j].Model)))
                {
                    temp[i].UnitsSold += 1;
                    //temp[i].Brand = rc[i].Phone.Brand.BrandName;
                    temp[i].TotalAmount += rc[i].FinalPrice;
                }

            }
            return temp;
        }
    }
}
