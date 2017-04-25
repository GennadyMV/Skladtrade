using SkladtradeEntity.Models;
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
            //UpdateSchema();
          //  SaveOrderStatus();
            ShowOrderStatus();
            Console.ReadKey();
        }
        static void ShowOrderStatus()
        {
            foreach (var item in OrderStatus.GetAll())
            {
                Console.WriteLine(item.Name);
            }
        }
        static void SaveOrderStatus()
        {
            OrderStatus model = new OrderStatus();
            model.Name = "Новый заказ";
            model.Save();

            OrderStatus model1 = new OrderStatus();
            model1.Name = "Черновик";
            model1.Save();

            OrderStatus model2 = new OrderStatus();
            model2.Name = "Отправлен";
            model2.Save();

            OrderStatus model3 = new OrderStatus();
            model3.Name = "Оплачен";
            model3.Save();

            OrderStatus model4 = new OrderStatus();
            model4.Name = "Получен";
            model4.Save();

            OrderStatus model5 = new OrderStatus();
            model5.Name = "Отказано";
            model5.Save();

            OrderStatus model6 = new OrderStatus();
            model6.Name = "Отменен";
            model6.Save();

            OrderStatus model7 = new OrderStatus();
            model7.Name = "Закрыт";
            model7.Save();
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
