using DTOs;
using Microsoft.EntityFrameworkCore;
using Models.DBContext;
using Repository.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Repository
{
    public class ReportRepo : IReportRepo
    {
        private readonly ApplicationDbContext _context;
        public ReportRepo(ApplicationDbContext _context)
        {
            this._context = _context;
        }
        public IQueryable<TempDTO> GenerateMonthlyReport(DateTime fromDate, DateTime toDate)
        {
            var query = "select records.PhoneId, Phones.PhoneName, count(recordId) as UnitsSold, sum(FinalPrice) as TotalAmountEarned \r\nfrom Records \r\njoin Phones on Phones.PhoneId = Records.PhoneId\r\nwhere(Records.SoldDate > '" +
                fromDate.ToString() +
                "' and Records.SoldDate < '" +
                toDate.ToString() +
                "')\r\ngroup by records.PhoneId,Phones.PhoneName";

            IQueryable<TempDTO> queryLondonCustomers3 = 
                                        (from product in _context.Records
                                         where (product.SoldDate > fromDate
                                            && product.SoldDate < toDate)
                                         group product by product.PhoneId into g
                                         select new TempDTO
                                         {
                                             PhoneId = g.Select(prod => prod.PhoneId).FirstOrDefault(),
                                             UnitsSold = g.Count(),
                                             TotalAmountEarned = g.Sum(prod => prod.FinalPrice),
                                             PhoneName = g.Select(prod => prod.Phone.PhoneName).FirstOrDefault()
                                         });
            return queryLondonCustomers3;


            //var temp = _context.Records.Where(rec => rec.SoldDate > fromDate && rec.SoldDate < toDate);
            //var temp2 = _context.Records.FromSqlRaw("select PhoneId, sum(FinalPrice) as TotalPrice from Records group by PhoneId;");
            //var temp3 = _context.QRecords.FromSqlRaw("select PhoneId, count(recordId) as TotalSaleCount, sum(FinalPrice) as TotalPrice from Records group by PhoneId;");
            //var temp4 = _context.QRecords.FromSqlRaw("select records.PhoneId, Phones.PhoneName, count(recordId) as UnitsSold, sum(FinalPrice) as TotalPrice \r\nfrom Records \r\njoin Phones on Phones.PhoneId = Records.PhoneId\r\nwhere(Records.SoldDate > '2022-12-01' and Records.SoldDate < '2022-12-31')\r\ngroup by records.PhoneId,Phones.PhoneName");
            //var temp5 = _context.QRecords.FromSqlRaw(query);
            //return temp5;
        }


        public IQueryable<SalesReportDTO> GenerateMonthlyBranWiseReport(string BrandTemp, DateTime fromDate, DateTime toDate)
        {
            IQueryable<SalesReportDTO> queryLondonCustomers3 = (IQueryable<SalesReportDTO>)
                                        (from product in _context.Records
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
