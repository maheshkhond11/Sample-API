using Models.DBContext;
using Repository.IRepo;
using System.Xml.Linq;

namespace Repository
{
    public class BrandsRepo : IBrandsRepo
    {
        private readonly ApplicationDbContext _dbContext;
        public BrandsRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Brand> CreateBrand(Brand brand)
        {
            var obj = await _dbContext.Brands.AddAsync(brand);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public void DeleteBrand(Brand brand)
        {
            _dbContext.Brands.Remove(brand);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Brand> GetAllBrands()
        {
                return _dbContext.Brands.ToList();
        }

        public Brand GetBrandById(int Id)
        {
            return _dbContext.Brands.Where(x => x.BrandId == Id).FirstOrDefault();
        }

        public void UpdateBrand(Brand brand)
        {
            _dbContext.Brands.Update(brand);
            _dbContext.SaveChanges();
        }
    }
}
