using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fic.Core
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T: class
    {
        private readonly IDbContext _dbContext;
        public RepositoryBase(IDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
