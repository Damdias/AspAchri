using Fic.Core;
using System;

namespace Fic.DataEntity
{
    public class Customer : IBaseEntity<long>
    {
        public DateTime CreateDate{get;set;}

        public long ID { get; set; }
        public string Name { get; set; }
    }
}
