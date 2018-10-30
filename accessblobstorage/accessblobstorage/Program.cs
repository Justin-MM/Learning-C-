using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Configuration;

namespace accessblobstorage
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = System.Configuration.ConfigurationManager.AppSettings.Get("StorageConnectionString");
            CloudStorageAccount myStorageAccount = CloudStorageAccount.Parse(connectionString);

            CloudBlobClient blobClient = myStorageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference("myblobs");
            container.CreateIfNotExists();

            ListAttributes(container);
            SetMetadata(container);
            ListMetadata(container);
            CopyBlob(container);
            CreateSubDirectories(container);
                                
        }
        public static void Uploadblob(CloudBlobContainer container)
        {
            using (var filestream = System.IO.File.OpenRead(@"C:\\Users\\Justin Macharia\\Pictures\\Camera Roll\\WIN_20180918_18_02_36_Pro.jpg"))
            {
                CloudBlockBlob blockblob = container.GetBlockBlobReference("images");
                blockblob.UploadFromStream(filestream);
            }
        }

        public static void Uploadblob(CloudBlobDirectory blobDirectory)
        {
            using (var filestream = System.IO.File.OpenRead(@"C:\\Users\\Justin Macharia\\Pictures\\Camera Roll\\WIN_20180918_18_02_36_Pro.jpg"))
            {
                CloudBlockBlob blockblob = blobDirectory.GetBlockBlobReference("images");
                blockblob.UploadFromStream(filestream);
            }
        }

        public static void ListAttributes(CloudBlobContainer container)
        {
            container.FetchAttributes();
            Console.WriteLine("container name " + container.StorageUri.PrimaryUri.ToString());
            Console.WriteLine("last modified " + container.Properties.LastModified.ToString());
            Console.ReadLine();
        }

        public static void SetMetadata(CloudBlobContainer container)
        {
            container.Metadata.Clear();
            container.Metadata.Add("Author", "Justin Macharia");
            container.Metadata["authoredOn"] = "October 30, 2018";
            container.SetMetadata();
        }

        public static void ListMetadata(CloudBlobContainer container)
        {
            container.FetchAttributes();
            foreach (var item in container.Metadata)
            {
                Console.WriteLine("key " + item.Key);
                Console.WriteLine("Value " + item.Value);
                Console.ReadLine();
            }
        }
        // programmatically make a copy of a blob within azure
        public static void CopyBlob(CloudBlobContainer container)
        {
            CloudBlockBlob blockBlob = container.GetBlockBlobReference("images");
            CloudBlockBlob copyToBlockBlob = container.GetBlockBlobReference("images-copy");
            copyToBlockBlob.StartCopyAsync(new Uri(blockBlob.Uri.AbsoluteUri));
        }

        // create subdirectories in blob storage
        public static void CreateSubDirectories(CloudBlobContainer container)
        {
            CloudBlobDirectory blobDirectory = container.GetDirectoryReference("Personal Images");
            Uploadblob(blobDirectory);
        }
    }
}
