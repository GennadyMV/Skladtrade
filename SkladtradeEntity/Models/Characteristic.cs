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
    public class Characteristic : Entity.Common.BaseClass<Characteristic>
    {
        public virtual string Name { get; set; }


        public Characteristic()
        {
            Name = "";
        }

    }
}
