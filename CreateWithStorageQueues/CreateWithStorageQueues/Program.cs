using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using System.Configuration;

namespace CreateWithStorageQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                ConfigurationManager.AppSettings.Get("StorageConnectionString"));
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();
            CloudQueue queue = queueClient.GetQueueReference("testqueue");
            queue.CreateIfNotExists();

            CloudQueueMessage queueMessage = new CloudQueueMessage("This is the third message!");
            queue.AddMessage(queueMessage);

            //peek a message
            //CloudQueueMessage seeMessage = queue.PeekMessage();
            //Console.WriteLine(seeMessage.AsString);

            //get a message
            CloudQueueMessage seeMessage = queue.GetMessage();
            Console.WriteLine(seeMessage.AsString);
            Console.ReadLine();
        }
    }
}
