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
        private readonly IRepository<Brand> brandsRepo;
        private readonly IRepository<Phone> phonesRepo;
        private readonly IRepository<Sale> salesRepo;
        private readonly IRepository<Record> recordsRepo;
        public ReportService(IRepository<Brand> _brandsRepo, IRepository<Phone> _phonesRepo, IRepository<Sale> _salesRepo, IRepository<Record> _recordsRepo)
        {
            brandsRepo = _brandsRepo;
            phonesRepo = _phonesRepo;
            salesRepo = _salesRepo;
            recordsRepo = _recordsRepo;
        }

        public IQueryable<SalesReportDTO> GenerateMonthlyReport(DateTime fromDate, DateTime toDate)
        {
            var query = "select records.PhoneId, Phones.PhoneName, count(recordId) as UnitsSold, sum(FinalPrice) as TotalAmountEarned \r\nfrom Records \r\njoin Phones on Phones.PhoneId = Records.PhoneId\r\nwhere(Records.SoldDate > '" +
                fromDate.ToString() +
                "' and Records.SoldDate < '" +
                toDate.ToString() +
                "')\r\ngroup by records.PhoneId,Phones.PhoneName";

            IQueryable<SalesReportDTO> queryLondonCustomers3 =
                                        (from product in recordsRepo.Table
                                         where (product.SoldDate > fromDate
                                            && product.SoldDate < toDate)
                                         group product by product.PhoneId into g
                                         select new SalesReportDTO
                                         {
                                             PhoneId = g.Select(prod => prod.PhoneId).FirstOrDefault(),
                                             UnitsSold = g.Count(),
                                             TotalAmountEarned = g.Sum(prod => prod.FinalPrice),
                                             PhoneName = g.Select(prod => prod.Phone.PhoneName).FirstOrDefault()
                                         });
            return queryLondonCustomers3;
        }


        public IQueryable<SalesReportDTO> GenerateMonthlyBranWiseReport(string BrandTemp, DateTime fromDate, DateTime toDate)
        {
            IQueryable<SalesReportDTO> queryLondonCustomers3 = (IQueryable<SalesReportDTO>)
                                        (from product in recordsRepo.Table
                                         where ((product.Phone.Brand.BrandName).Equals(BrandTemp)
                                            && product.SoldDate > fromDate
                                            && product.SoldDate < toDate)
                                         group product by product.PhoneId into g
                                         select new SalesReportDTO
                                         {
                                             Brand = g.Select(product => product.Phone.Brand.BrandName).FirstOrDefault(),
                                             Model = g.Select(prod => prod.Phone.PhoneName).FirstOrDefault(),
                                             UnitsSold = g.Count(),
                                             TotalAmount = g.Sum(prod => prod.FinalPrice)
                                         });
            return queryLondonCustomers3;
        }
    }
}
