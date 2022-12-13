using Models.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepo
{
    public interface IPhonesRepo
    {
        public Task<Phone> CreatePhone(Phone phone);

        public void UpdatePhone(Phone phone);

        public IEnumerable<Phone> GetAllPhones();

        public Phone GetPhoneById(int Id);

        public void DeletePhone(Phone phone);
    }
}
