using System;

namespace Fic.Core
{
    public interface IBaseEntity<T>
    {
        T ID { get; set; }
       DateTime CreateDate { get; set; }
    }
}
