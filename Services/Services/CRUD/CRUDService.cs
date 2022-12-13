using Models.DBContext;
using Repository;
using Repository.IRepo;
using Services.Services.CRUD.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.CRUD
{
    public class CRUDService : ICRUDService
    {
        private readonly IBrandsRepo brandsRepo;
        private readonly IPhonesRepo phonesRepo;
        private readonly ISalesRepo salesRepo;
        private readonly IRecordsRepo recordsRepo;
        public CRUDService(IBrandsRepo _brandsRepo, IPhonesRepo _phonesRepo, ISalesRepo _salesRepo, IRecordsRepo _recordsRepo)
        {
            brandsRepo = _brandsRepo;
            phonesRepo = _phonesRepo;
            salesRepo = _salesRepo;
            recordsRepo = _recordsRepo;
        }
        //Brand
        public Task<Brand> CreateBrand(Brand brand)
        {
            return brandsRepo.CreateBrand(brand);
        }

        public bool DeleteBrand(string brandName)
        {
            try
            {
                var DataList = brandsRepo.GetAllBrands().Where(x => x.BrandName == brandName).ToList();
                foreach (var item in DataList)
                {
                    brandsRepo.DeleteBrand(item);
                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public IEnumerable<Brand> GetAllBrands()
        {
            return brandsRepo.GetAllBrands();
        }

        public Brand GetBrandById(int Id)
        {
            return brandsRepo.GetBrandById(Id); 
        }

        public void UpdateBrand(Brand brand)
        {
            brandsRepo.UpdateBrand(brand);
        }
        //Phone
        public Task<Phone> CreatePhone(Phone phone)
        {
            return phonesRepo.CreatePhone(phone);
        }

        public bool DeletePhone(string phonename)
        {
            try
            {
                var DataList = phonesRepo.GetAllPhones().Where(x => x.PhoneName == phonename).ToList();
                foreach (var item in DataList)
                {
                    phonesRepo.DeletePhone(item);
                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public IEnumerable<Phone> GetAllPhones()
        {
            return phonesRepo.GetAllPhones();
        }

        public Phone GetPhoneById(int Id)
        {
            return phonesRepo.GetPhoneById(Id);
        }

        public void UpdatePhone(Phone phone)
        {
            phonesRepo.UpdatePhone(phone);
        }
        //Sales
        public Task<Sale> CreateSale(Sale sale)
        {
            return salesRepo.CreateSale(sale);
        }

        public bool DeleteSale(string saleName)
        {
            try
            {
                var DataList = salesRepo.GetAllSales().Where(x => x.SaleName == saleName).ToList();
                foreach (var item in DataList)
                {
                    salesRepo.DeleteSale(item);
                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public IEnumerable<Sale> GetAllSales()
        {
            return salesRepo.GetAllSales();
        }

        public Sale GetSaleById(int Id)
        {
            return salesRepo.GetSaleById(Id);
        }

        public void UpdateSale(Sale sale)
        {
            salesRepo.UpdateSale(sale);
        }
        //Records
        public Task<Record> CreateRecord(Record record)
        {
            return recordsRepo.CreateRecord(record);
        }

        public bool DeleteRecord(int id)
        {
            try
            {
                var DataList = recordsRepo.GetAllRecords().Where(x => x.RecordId == id).ToList();
                foreach (var item in DataList)
                {
                    recordsRepo.DeleteRecord(item);
                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public IEnumerable<Record> GetAllRecords()
        {
            return recordsRepo.GetAllRecords();
        }

        public Record GetRecordById(int Id)
        {
            return recordsRepo.GetRecordById(Id);
        }

        public void UpdateRecord(Record record)
        {
            recordsRepo.UpdateRecord(record);
        }
    }
}
