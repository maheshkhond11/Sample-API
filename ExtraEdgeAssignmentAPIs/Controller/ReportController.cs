using DTOs;
using ExtraEdgeAssignmentAPIs.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DBContext;
using Repository.IRepo;
using Services.Services.Report.Interface;

namespace _ExtraEdgeAssignmentAPIs.Controller
{
    public class ReportController : BaseAPIController
    {
        private readonly IReportService reportService;
        private readonly IReportRepo repo;
        public ReportController(IReportService _reportService, IReportRepo _repo)
        {
            reportService = _reportService;
            repo = _repo;
        }
        [HttpGet]
        public IQueryable<TempDTO> GenerateMonthlySalesReport(DateTime fromDate, DateTime toDate)
        {
            //var temp = reportService.GenerateMonthlyReport(fromDate, toDate);
            var temp = repo.GenerateMonthlyReport(fromDate, toDate);
            return temp;
        }
        [HttpGet]
        public IEnumerable<SalesReportDTO> GenerateMonthlyBrandwiseSalesReport(string brand,DateTime fromDate, DateTime toDate)
        {
            return repo.GenerateMonthlyBranWiseReport(brand, fromDate, toDate);
        }
        
    }
}
