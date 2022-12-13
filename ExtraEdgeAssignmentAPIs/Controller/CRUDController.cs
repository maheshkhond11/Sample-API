using ExtraEdgeAssignmentAPIs.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services.CRUD.Interface;
using System.Xml;
using System;
using Models.DBContext;

namespace _ExtraEdgeAssignmentAPIs.Controller
{
    public class CRUDController : BaseAPIController
    {
        private readonly ICRUDService _cRUDService;
        public CRUDController(ICRUDService cRUDService)
        {
            _cRUDService = cRUDService;
        }
        #region Brand
        //post
        [HttpPost("AddBrand")]
        public async Task<Object> AddPhone([FromBody] Brand brand)
        {
            try
            {
                await _cRUDService.CreateBrand(brand);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
       //Delete
        [HttpDelete("DeleteBrand")]
        public bool DeleteBrand(string BrandName)
        {
            try
            {
                _cRUDService.DeleteBrand(BrandName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Patch
        [HttpPatch("UpdateBrand")]
        public bool UpdatePerson(Brand brand)
        {
            try
            {
                _cRUDService.UpdateBrand(brand);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Get All
        [HttpGet("GetAllBrands")]
        public IEnumerable<Brand> GetAllBrands()
        {
            var data = _cRUDService.GetAllBrands();
            return data;
        }
        [HttpGet("GetById")]
        public Brand GetBrandById(int id)
        {
            var data = _cRUDService.GetBrandById(id);
            return data;
        }
        #endregion
        #region Phone
        //post
        [HttpPost("AddPhone")]
        public async Task<Object> AddPhone(Phone phone)
        {
            try
            {
                await _cRUDService.CreatePhone(phone);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Delete
        [HttpDelete("DeletePhone")]
        public bool DeletePhone(string PhoneName)
        {
            try
            {
                _cRUDService.DeletePhone(PhoneName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Patch
        [HttpPatch("UpdatePhone")]
        public bool UpdatePhone(Phone phone)
        {
            try
            {
                _cRUDService.UpdatePhone(phone);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Get All
        [HttpGet("GetAllPhones")]
        public IEnumerable<Phone> GetAllPhones()
        {
            var data = _cRUDService.GetAllPhones();
            return data;
        }
        [HttpGet("GetById")]
        public Phone GetPhoneById(int id)
        {
            var data = _cRUDService.GetPhoneById(id);
            return data;
        }
        #endregion
        #region Sale
        //post
        [HttpPost("AddSale")]
        public async Task<Object> AddSale([FromBody] Sale sale)
        {
            try
            {
                await _cRUDService.CreateSale(sale);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Delete
        [HttpDelete("DeleteSale")]
        public bool DeleteSale(string SaleName)
        {
            try
            {
                _cRUDService.DeleteSale(SaleName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Patch
        [HttpPatch("UpdateSale")]
        public bool UpdateSale(Sale sale)
        {
            try
            {
                _cRUDService.UpdateSale(sale);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Get All
        [HttpGet("GetAllSales")]
        public IEnumerable<Sale> GetAllSales()
        {
            var data = _cRUDService.GetAllSales();
            return data;
        }
        [HttpGet("GetById")]
        public Sale GetSaleById(int id)
        {
            var data = _cRUDService.GetSaleById(id);
            return data;
        }
        #endregion
        #region Record
        //post
        [HttpPost("AddRecord")]
        public async Task<Object> AddRecord(Record record)
        {
            try
            {
                await _cRUDService.CreateRecord(record);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Delete
        [HttpDelete("DeleteRecord")]
        public bool DeleteRecord(int id)
        {
            try
            {
                _cRUDService.DeleteRecord(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Patch
        [HttpPatch("UpdateRecord")]
        public bool UpdateRecord(Record record)
        {
            try
            {
                _cRUDService.UpdateRecord(record);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Get All
        [HttpGet("GetAllRecords")]
        public IEnumerable<Record> GetAllRecords()
        {
            var data = _cRUDService.GetAllRecords();
            return data;
        }
        [HttpGet("GetById")]
        public Record GetRecordById(int id)
        {
            var data = _cRUDService.GetRecordById(id);
            return data;
        }
        #endregion
    }
}
