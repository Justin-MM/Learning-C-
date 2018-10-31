using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System.Configuration;

namespace AccessTableStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                System.Configuration.ConfigurationManager.AppSettings.Get("StorageConnectionString"));

            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();
            CloudTable table = tableClient.GetTableReference("TestTable");
            table.CreateIfNotExists();

            // CarEntity myCar = new CarEntity(1, "Ford", "Ranger", 2017, "Black");
            // TableOperation insert = TableOperation.Insert(myCar);
            // table.Execute(insert);

            TableOperation retrieve = TableOperation.Retrieve<CarEntity>("car", "1");
            TableResult result = table.Execute(retrieve);

            if (result.Result == null)
            {
                Console.WriteLine("Car not Found");
            }
            else
            {
                Console.WriteLine("Found Car " + ((CarEntity)result.Result).Make + " " + ((CarEntity)result.Result).Model);
            }
            Console.ReadLine();
        }
    }

    public class CarEntity : TableEntity
    {
        public CarEntity(int ID, string make, string model, int year, string color)
        {
            this.UniqueID = ID;
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
            this.PartitionKey = "car";
            this.RowKey = ID.ToString();
        }

        public CarEntity() { }

        public int UniqueID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}
