using Models.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepo
{
    public interface ISalesRepo
    {
        public Task<Sale> CreateSale(Sale sale);

        public void UpdateSale(Sale sale);

        public IEnumerable<Sale> GetAllSales();

        public Sale GetSaleById(int Id);

        public void DeleteSale(Sale Sale);
    }
}
