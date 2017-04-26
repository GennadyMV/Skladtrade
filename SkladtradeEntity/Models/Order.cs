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
    public class Order : Entity.Common.BaseClass<Order>
    {
        public virtual string Number { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public virtual string Document { get; set;}

        public virtual OrderStatus OrderStatus { get; set; }

        public virtual string Name
        {
            get
            {
                return this.updated_at.ToString() + " Заказ № " + this.ID.ToString("0000") + " # " + this.Number + " " + "на сумму: " + this.OrderProducts.Sum(x=>x.Product.Price) + " руб. Статус: " + this.OrderStatus.Name + " Производитель: " + this.Manufacturer.Name;
            }
        }

        private ICollection<OrderProduct> _OrderProducts;
        public virtual ICollection<OrderProduct> OrderProducts
        {
            get
            {
                return this._OrderProducts;
            }
            set
            {
                this._OrderProducts = value;
            }
        }
       
        public Order()
        {
            this._OrderProducts = new System.Collections.Generic.HashSet<OrderProduct>();           
        }


    }
}
