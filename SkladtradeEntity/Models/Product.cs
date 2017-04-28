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
    public class Product : Entity.Common.BaseClass<Product>
    {
        public virtual string Code { get; set; }

        public virtual Category Category { get; set; }

        public virtual Manufacturer Manufacturer {get; set;}

        public virtual Type Type { get; set; }

        public virtual string Description { get; set; }

        public virtual Decimal Price { get; set; }

        public virtual int Balance { get; set; }

        public virtual string Name
        {
            get
            {
                return this.Code + " - " + this.Category.Name +" (" + this.Manufacturer.Name + ") Цена: "  + Price.ToString() + " руб.";
            }
        }

        private ICollection<Characteristic> _Characteristics;

        public Product()
        {
            this._Characteristics = new System.Collections.Generic.HashSet<Characteristic>();
        }

        public virtual ICollection<Characteristic> Characteristics
        {
            get
            {
                return this._Characteristics;
            }
            set
            {
                this._Characteristics = value;
            }
        }
        public virtual void ClearCharacteristics()
        {
            this.Characteristics.Clear();
        }

        public virtual Boolean IsExistCharacteristic(int CharacteristicID)
        {
            foreach (var theCharacteristic in this.Characteristics)
            {
                if (theCharacteristic.ID == CharacteristicID)
                {
                    return true;
                }
            }
            return false;
        }  

    }
}
