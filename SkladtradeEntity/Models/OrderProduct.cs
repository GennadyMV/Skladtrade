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
    public class OrderProduct : Entity.Common.BaseClass<OrderProduct>
    {
        public virtual Product Product { get; set; }
        public virtual int Count { get; set; }

        public virtual Order Order { get; set; }
        
        public OrderProduct()
        {
        
        }


    }
}
