using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Nodes;
using System.Runtime.Serialization.Formatters.Binary;

namespace CKK.Persistance.Models
{
    public class FileStore : IStore
    { 
        public string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar + "Persistance" + Path.DirectorySeparatorChar + "StoreItems.dat";
        private List<StoreItem> _items = new List<StoreItem>();
        public FileStore()
        {
            _items = new List<StoreItem>();
            
            
        }
        private void CreatePath()
        {
            try
            {
                if(Directory.Exists(filePath))
                {
                    Console.WriteLine("That path exists already");
                    return;
                }
                DirectoryInfo di = Directory.CreateDirectory(filePath);
                Console.WriteLine("the directory was created successfully at {0}", Directory.GetCreationTime(filePath));
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }
        public List<StoreItem> GetStoreItems()
        {
            return _items;
        }
        public void Save()
        {
            BinaryFormatter format = new BinaryFormatter();

            //JsonSerializer serializer = new JsonSerializer();
            format.Serialize(_items,);

            string output = JsonConvert.SerializeObject(_items);
        }
    }
}
