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
    public class Settings : Entity.Common.BaseClass<Settings>
    {
        public virtual string Name { get; set; }

        public virtual string Value { get; set; }

        public virtual string VarName { get; set; }

        public Settings()
        {
            Name = "";
            Value = "";
            VarName = "";
        }

        public static Dictionary<string, Settings> GetDictionary()
        {
            Dictionary<string, Settings> dic = new Dictionary<string, Settings>();
            foreach (Settings item in Settings.GetAll())
            {
                dic.Add(item.VarName, item);
            }
            return dic;
        }

        public static string GetValueByVarName(string varName)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                ICriteria criteria = session.CreateCriteria(typeof(Settings));
                criteria.Add(Restrictions.Eq("VarName", varName));

                return criteria.UniqueResult<Settings>().Value;
            }
        }
    }
}
