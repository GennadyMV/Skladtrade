using Entity.Common;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladtradeEntity.Models
{
    public class Manufacturer : Entity.Common.BaseClass<Manufacturer>
    {
        public virtual string Name { get; set; }


        public Manufacturer()
        {
            Name = "";
        }

    }
}
