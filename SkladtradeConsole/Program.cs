using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladtradeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            UpdateSchema();
            Console.ReadKey();
        }
        static void UpdateSchema()
        {
            Entity.Common.NHibernateHelper.UpdateSchema();
        }

        //public static void Init()
        //{
        //    // Initialize NHibernate
        //    cfg = new Configuration();
        //    cfg.Configure();
        //    IDictionary<string, string> props = new Dictionary<string, string>();
        //    props.Add("connection.connection_string", CONNECTION_STRING);
        //    props.Add("connection.driver_class", "NHibernate.Driver.SQLite20Driver");
        //    props.Add("dialect", "NHibernate.Dialect.SQLiteDialect");
        //    props.Add("proxyfactory.factory_class", "NHibernate.ByteCode.LinFu.ProxyFactoryFactory, NHibernate.ByteCode.LinFu");
        //    props.Add("query.substitutions", "true=1;false=0");
        //    props.Add("show_sql", "false");
        //    cfg.SetProperties(props);
        //    cfg.AddAssembly(typeof(Person).Assembly);
        //    connection = new SQLiteConnection(CONNECTION_STRING);
        //    connection.Open();

        //    // Get ourselves an NHibernate Session
        //    var sessions = cfg.BuildSessionFactory();
        //    sess = sessions.OpenSession();
        //}

        //private static void BuildSchema()
        //{
        //    NHibernate.Tool.hbm2ddl.SchemaExport schemaExport
        //        = new NHibernate.Tool.hbm2ddl.SchemaExport(cfg);
        //    schemaExport.Execute(false, true, false, connection, null);
        //}


    }
}
