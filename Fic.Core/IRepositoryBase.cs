using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fic.Core
{
   public interface IRepositoryBase<T> where T : class
    {
        void Add(T entity);
    }
}
