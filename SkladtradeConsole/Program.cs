using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using SkladtradeEntity.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


using Google.Apis.Drive.v3.Data;
using System.IO;


namespace SkladtradeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //UpdateSchema();
          //  SaveOrderStatus();
            //ShowOrderStatus();
            SupportGoogleDrive();
            Console.ReadKey();
        }

        private static string GetMimeType(string fileName)
{
    string mimeType = "application/unknown";
    string ext = System.IO.Path.GetExtension(fileName).ToLower();
    Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
    if (regKey != null && regKey.GetValue("Content Type") != null)
        mimeType = regKey.GetValue("Content Type").ToString();
    return mimeType;
}
      


        static void SupportGoogleDrive()
        {
            try
            {
                 string[] Scopes = {  DriveService.Scope.DriveReadonly };
                 string ApplicationName = "Drive API .NET Quickstart";

                 UserCredential credential;

                 using (var stream =
                     new FileStream("client_id.json", FileMode.Open, FileAccess.Read))
                 {
                     string credPath = System.Environment.GetFolderPath(
                         System.Environment.SpecialFolder.Personal);
                     credPath = Path.Combine(credPath, ".credentials/drive-dotnet-quickstart.json");

                     credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                         GoogleClientSecrets.Load(stream).Secrets,
                         Scopes,
                         "user",
                         CancellationToken.None,
                         new FileDataStore(credPath, true)).Result;
                     Console.WriteLine("Credential file saved to: " + credPath);
                 }

                 // Create Drive API service.
                 var service = new DriveService(new BaseClientService.Initializer()
                 {
                     HttpClientInitializer = credential,
                     ApplicationName = ApplicationName,
                 });

                
                Google.Apis.Drive.v3.Data.File file1 = new Google.Apis.Drive.v3.Data.File();
                file1.Name = "nhlite.db";
                file1.Description = "Test";
                file1.MimeType = "text/plain";

                byte[] byteArray = System.IO.File.ReadAllBytes("nhlite.db");
                System.IO.MemoryStream stream1 = new System.IO.MemoryStream(byteArray);

                FilesResource.CreateMediaUpload request = service.Files.Create(file1, stream1, "text/plain");
                request.Upload();

                
                 // Define parameters of request.
                 FilesResource.ListRequest listRequest = service.Files.List();
                 listRequest.PageSize = 10;
                 listRequest.Fields = "nextPageToken, files(id, name)";

                 // List files.
                 IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute()
                     .Files;
                 Console.WriteLine("Files:");
                 if (files != null && files.Count > 0)
                 {
                     foreach (var file in files)
                     {
                         Console.WriteLine("{0} ({1})", file.Name, file.Id);
                     }
                 }
                 else
                 {
                     Console.WriteLine("No files found.");
                 }
                 Console.Read();



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
