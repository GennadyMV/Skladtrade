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
        public virtual Category Category { get; set; }

        public Characteristic()
        {
            Name = "";
        }

        public static List<Characteristic> GetAllByCategory(Category theCategory)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                ICriteria criteria = session.CreateCriteria(typeof(Characteristic));
                criteria.AddOrder(NHibernate.Criterion.Order.Desc("ID"));
                criteria.Add(Restrictions.Eq("Category", theCategory));
                return criteria.List<Characteristic>().ToList<Characteristic>();
            }
        }

    }
}
