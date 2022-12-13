using Models.DBContext;
using Repository.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RecordsRepo : IRecordsRepo
    {
        private readonly ApplicationDbContext _dbContext;
        public RecordsRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Record> CreateRecord(Record record)
        {
            var obj = await _dbContext.Records.AddAsync(record);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public void DeleteRecord(Record record)
        {
            _dbContext.Records.Remove(record);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Record> GetAllRecords()
        {
                return _dbContext.Records.ToList();
        }

        public Record GetRecordById(int Id)
        {
            return _dbContext.Records.Where(x => x.RecordId == Id).FirstOrDefault();
        }

        public void UpdateRecord(Record record)
        {
            _dbContext.Records.Update(record);
            _dbContext.SaveChanges();
        }
    }
}
