using Models.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepo
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        public Task Add(TEntity entity);

        public void Update(TEntity entity);

        public IEnumerable<TEntity> GetAll();

        public TEntity GetById(int id);

        public void Delete(TEntity entity);

        IQueryable<TEntity> Table { get; }
    }
}
