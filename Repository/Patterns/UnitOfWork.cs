using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository.Patterns
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        protected DbContext DataContext { get; set; }
        private DbContextTransaction _transaction;

        protected UnitOfWork(DbContext context)
        {
            DataContext = context;
        }

        public void BeginTransaction()
        {
            _transaction = DataContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public int Save()
        {
            return DataContext.SaveChanges();
        }

        public void Dispose()
        {
            _transaction.Dispose();
            DataContext.Dispose();
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }
    }
}
