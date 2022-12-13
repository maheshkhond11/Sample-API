using Models.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepo
{
    public interface IRecordsRepo
    {
        public Task<Record> CreateRecord(Record record);

        public void UpdateRecord(Record record);

        public IEnumerable<Record> GetAllRecords();

        public Record GetRecordById(int Id);

        public void DeleteRecord(Record record);
    }
}
