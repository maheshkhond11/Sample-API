using Models.DBContext;
using Repository.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PhonesRepo : IPhonesRepo
    {

        private readonly ApplicationDbContext _dbContext;
        public PhonesRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Phone> CreatePhone(Phone phone)
        {
            var obj = await _dbContext.Phones.AddAsync(phone);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public void DeletePhone(Phone phone)
        {
            _dbContext.Phones.Remove(phone);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Phone> GetAllPhones()
        {
            try
            {
                return _dbContext.Phones.ToList();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public Phone GetPhoneById(int Id)
        {
            return _dbContext.Phones.Where(x => x.PhoneId == Id).FirstOrDefault();
        }

        public void UpdatePhone(Phone phone)
        {
            _dbContext.Phones.Update(phone);
            _dbContext.SaveChanges();
        }
    }
}
