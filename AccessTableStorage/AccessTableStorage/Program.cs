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
            /*
            CarEntity myCar = new CarEntity(2, "Toyota", "Prado V8", 2016, "White");
            InsertToTable(table, myCar);
            myCar = new CarEntity(3, "Honda", "Civic", 2012, "Yellow");
            InsertToTable(table, myCar);
            myCar = new CarEntity(4, "Subaru", "Imprezza", 2010, "Blue");
            InsertToTable(table, myCar);
            myCar = new CarEntity(5, "Range Rover", "Evoque", 2015, "White");
            InsertToTable(table, myCar);
            */
            TableOperation retrieve = TableOperation.Retrieve<CarEntity>("car", "1");
            TableResult result = table.Execute(retrieve);

            if (result.Result == null)
            {
                Console.WriteLine("Car not Found");
            }
            else
            {
                TableQuery<CarEntity> query = new TableQuery<CarEntity>();
                foreach (CarEntity thisCar in table.ExecuteQuery(query))
                {
                    Console.WriteLine("Found Car " + thisCar.Make + " " + thisCar.Model + " " + thisCar.Year.ToString());
                }
                
            } 
            Console.ReadLine();
        }

        public static void InsertToTable(CloudTable table, CarEntity car)
        {
            TableOperation insert = TableOperation.Insert(car);
            table.Execute(insert);
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
