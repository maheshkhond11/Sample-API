using Models.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepo
{
    public interface IBrandsRepo
    {
        public Task<Brand> CreateBrand(Brand brand);

        public void UpdateBrand(Brand brand);

        public IEnumerable<Brand> GetAllBrands();

        public Brand GetBrandById(int Id);

        public void DeleteBrand(Brand brand);
    }
}
