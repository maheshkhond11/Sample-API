using Models.DBContext;
using Repository.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SalesRepo : ISalesRepo
    {

        private readonly ApplicationDbContext _dbContext;
        public SalesRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Sale> CreateSale(Sale sale)
        {
            var obj = await _dbContext.Sales.AddAsync(sale);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public void DeleteSale(Sale sale)
        {
            _dbContext.Sales.Remove(sale);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Sale> GetAllSales()
        {
                return _dbContext.Sales.ToList();
        }

        public Sale GetSaleById(int Id)
        {
            return _dbContext.Sales.Where(x => x.SaleId == Id).FirstOrDefault();
        }

        public void UpdateSale(Sale sale)
        {
            _dbContext.Sales.Update(sale);
            _dbContext.SaveChanges();
        }
    }
}
