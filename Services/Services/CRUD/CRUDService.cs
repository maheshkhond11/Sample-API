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
        private readonly IRepository<Brand> brandsRepo;
        private readonly IRepository<Phone> phonesRepo;
        private readonly IRepository<Sale> salesRepo;
        private readonly IRepository<Record> recordsRepo;
        public CRUDService(IRepository<Brand> _brandsRepo, IRepository<Phone> _phonesRepo, IRepository<Sale> _salesRepo, IRepository<Record> _recordsRepo)
        {
            brandsRepo = _brandsRepo;
            phonesRepo = _phonesRepo;
            salesRepo = _salesRepo;
            recordsRepo = _recordsRepo;
        }
        //Brand
        public async Task CreateBrand(Brand brand)
        {
            await brandsRepo.Add(brand);
        }

        public bool DeleteBrand(string brandName)
        {
            try
            {
                var DataList = brandsRepo.GetAll().Where(x => x.BrandName == brandName).ToList();
                foreach (var item in DataList)
                {
                    brandsRepo.Delete(item);
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
            return brandsRepo.GetAll();
        }

        public Brand GetBrandById(int Id)
        {
            return brandsRepo.GetById(Id); 
        }

        public bool UpdateBrand(Brand brand)
        {
            brandsRepo.Update(brand);
            return true;
        }
        //Phone
        public async Task CreatePhone(Phone phone)
        {
            await phonesRepo.Add(phone);
        }

        public bool DeletePhone(string phonename)
        {
            try
            {
                var DataList = phonesRepo.GetAll().Where(x => x.PhoneName == phonename).ToList();
                foreach (var item in DataList)
                {
                    phonesRepo.Delete(item);
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
            return phonesRepo.GetAll();
        }

        public Phone GetPhoneById(int Id)
        {
            return phonesRepo.GetById(Id);
        }

        public void UpdatePhone(Phone phone)
        {
            phonesRepo.Update(phone);
        }
        //Sales
        public async Task CreateSale(Sale sale)
        {
            await salesRepo.Add(sale);
        }

        public bool DeleteSale(string saleName)
        {
            try
            {
                var DataList = salesRepo.GetAll().Where(x => x.SaleName == saleName).ToList();
                foreach (var item in DataList)
                {
                    salesRepo.Delete(item);
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
            return salesRepo.GetAll();
        }

        public Sale GetSaleById(int Id)
        {
            return salesRepo.GetById(Id);
        }
        public void UpdateSale(Sale sale)
        {
            salesRepo.Update(sale);
        }
        //Records
        public async Task CreateRecord(Record record)
        {
            await recordsRepo.Add(record);
        }
        public bool DeleteRecord(int id)
        {
            try
            {
                var DataList = recordsRepo.GetAll().Where(x => x.RecordId == id).ToList();
                foreach (var item in DataList)
                {
                    recordsRepo.Delete(item);
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
            return recordsRepo.GetAll();
        }

        public Record GetRecordById(int Id)
        {
            return recordsRepo.GetById(Id);
        }

        public void UpdateRecord(Record record)
        {
            recordsRepo.Update(record);
        }
    }
}
