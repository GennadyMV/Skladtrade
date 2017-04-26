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
    public class Sale : Entity.Common.BaseClass<Sale>
    {
        public virtual string Number { get; set; }             

        public virtual Manufacturer Manufacturer {get; set;}

        public virtual string Description { get; set; }

        public virtual string Document { get; set; }

        public virtual Decimal Price { get; set; }
        public virtual int Count { get; set; }

        public virtual Product Product { get; set; }

        public virtual String Name
        {
            get
            {
                return this.created_at.ToString() + " Продажа № " + this.ID.ToString("0000") + " # " + this.Number + " на сумму: " + this.Price + " руб.";
            }
        }
        public Sale()
        {
        
        }


    }
}
