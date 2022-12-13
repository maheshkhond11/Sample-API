using Models.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.CRUD.Interface
{
    public interface ICRUDService
    {
        //Brands
        public Task<Brand> CreateBrand(Brand brand);

        public bool UpdateBrand(Brand brand);

        public IEnumerable<Brand> GetAllBrands();

        public Brand GetBrandById(int Id);

        public bool DeleteBrand(string brandname);
        //Phones
        public Task<Phone> CreatePhone(Phone phone);

        public void UpdatePhone(Phone phone);

        public IEnumerable<Phone> GetAllPhones();

        public Phone GetPhoneById(int Id);

        public bool DeletePhone(string phonename);
        //Sales
        public Task<Sale> CreateSale(Sale sale);

        public void UpdateSale(Sale sale);

        public IEnumerable<Sale> GetAllSales();

        public Sale GetSaleById(int Id);

        public bool DeleteSale(string salename);
        //Records
        public Task<Record> CreateRecord(Record record);

        public void UpdateRecord(Record record);

        public IEnumerable<Record> GetAllRecords();

        public Record GetRecordById(int Id);

        public bool DeleteRecord(int id);

    }
}
