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
        [HttpPost]
        public IActionResult AddBrand(Brand brand)
        {
            if(brand == null)
                return BadRequest();
            if(ModelState.IsValid)
                return Ok(_cRUDService.CreateBrand(brand));
            return BadRequest();
        }
       //Delete
        [HttpDelete]
        public IActionResult DeleteBrand(string BrandName)
        {
            if (BrandName == null)
                return BadRequest();
            if(ModelState.IsValid)
                return  Ok(_cRUDService.DeleteBrand(BrandName));
            return BadRequest();
        }
        //Patch
        [HttpPatch]
        public IActionResult UpdateBrand(Brand brand)
        {
            if(_cRUDService.UpdateBrand(brand))
                return Ok();
            return BadRequest();
        }
        //Get All
        [HttpGet]
        public ActionResult<IEnumerable<Brand>> GetAllBrands()
        {
            if (!ModelState.IsValid)
                return BadRequest();
            return Ok(_cRUDService.GetAllBrands());
        }
        [HttpGet]
        public ActionResult<Brand> GetBrandById(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var data = _cRUDService.GetBrandById(id);
            return Ok(data);
        }
        #endregion
        #region Phone
        //post
        [HttpPost]
        public IActionResult AddPhone(Phone phone)
        {
            if (phone== null)
                return BadRequest();
            if (ModelState.IsValid)
                return Ok(_cRUDService.CreatePhone(phone));
            return BadRequest();
        }
        //Delete
        [HttpDelete]
        public IActionResult DeletePhone(string PhoneName)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            _cRUDService.DeletePhone(PhoneName);
                return Ok(true);
        }
        //Patch
        [HttpPatch]
        public IActionResult UpdatePhone(Phone phone)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            _cRUDService.UpdatePhone(phone);
                return Ok(true);
        }
        //Get All
        [HttpGet]
        public ActionResult<IEnumerable<Phone>> GetAllPhones()
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var data = _cRUDService.GetAllPhones();
            return Ok(data);
        }
        [HttpGet]
        public ActionResult<Phone> GetPhoneById(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var data = _cRUDService.GetPhoneById(id);
            return Ok(data);
        }
        #endregion
        #region Sale
        //post
        [HttpPost]
        public IActionResult AddSale(Sale sale)
        {
            if (sale == null)
                return BadRequest();
            if (ModelState.IsValid)
                return Ok(_cRUDService.CreateSale(sale));
            return BadRequest();
        }
        //Delete
        [HttpDelete]
        public IActionResult DeleteSale(string SaleName)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            _cRUDService.DeleteSale(SaleName);
                return Ok(true);
        }
        //Patch
        [HttpPatch]
        public IActionResult UpdateSale(Sale sale)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            _cRUDService.UpdateSale(sale);
                return Ok(true);
        }
        //Get All
        [HttpGet]
        public ActionResult<IEnumerable<Sale>> GetAllSales()
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var data = _cRUDService.GetAllSales();
            return Ok(data);
        }
        [HttpGet]
        public ActionResult<Sale> GetSaleById(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var data = _cRUDService.GetSaleById(id);
            return Ok(data);
        }
        #endregion
        #region Record
        //post
        [HttpPost]
        public IActionResult AddRecord(Record record)
        {
            if (record == null)
                return BadRequest();
            if (ModelState.IsValid)
                return Ok(_cRUDService.CreateRecord(record));
            return BadRequest();
        }
        //Delete
        [HttpDelete]
        public IActionResult DeleteRecord(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            _cRUDService.DeleteRecord(id);
                return Ok(true);
        }
        //Patch
        [HttpPatch]
        public IActionResult UpdateRecord(Record record)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            _cRUDService.UpdateRecord(record);
                return Ok(true);
        }
        //Get All
        [HttpGet]
        public ActionResult<IEnumerable<Record>> GetAllRecords()
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var data = _cRUDService.GetAllRecords();
            return Ok(data);
        }
        [HttpGet]
        public ActionResult<Record> GetRecordById(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var data = _cRUDService.GetRecordById(id);
            return Ok(data);
        }
        #endregion
    }
}
