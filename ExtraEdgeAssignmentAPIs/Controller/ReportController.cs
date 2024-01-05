using DTOs;
using ExtraEdgeAssignmentAPIs.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DBContext;
using Repository.IRepo;
using Services.Services.Report;
using Services.Services.Report.Interface;

namespace _ExtraEdgeAssignmentAPIs.Controller
{
    public class ReportController : BaseAPIController
    {
        private readonly IReportService reportService;
        public ReportController(IReportService _reportService)
        {
            reportService = _reportService;
        }
        [HttpGet]
        public IQueryable<SalesReportDTO> GenerateMonthlySalesReport(DateTime fromDate, DateTime toDate)
        {
            return reportService.GenerateMonthlyReport(fromDate, toDate);
        }
        [HttpGet]
        public IEnumerable<SalesReportDTO> GenerateMonthlyBrandwiseSalesReport(string brand,DateTime fromDate, DateTime toDate)
        {
            return reportService.GenerateMonthlyBranWiseReport(brand, fromDate, toDate);
        }
        
    }
}
