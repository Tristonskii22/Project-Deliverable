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
using System.Runtime.Serialization;
using System.Net.Http.Json;

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
            using (var stream = File.Create("Persistance"))
            {
                format.Serialize(stream, _items);
            }
            
                
        }
        public void Load()
        {
            BinaryFormatter format = new BinaryFormatter();
            using (var stream = File.OpenRead("Persistance"))
            {
                if(File.Exists(filePath))
                {
                    _items = (List<StoreItem>)format.Deserialize(stream);
                }
            }
        }
        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            // int newId = 100;
            var itemToAdd = FindStoreItemById(prod.Id);

            /*
             * if (itemToAdd.Product.Id == 0)
            {
                itemToAdd.Product.Id = newId;
                newId++;
            }
            */

            if (quantity < 0)
            {
                throw new InventoryItemStockTooLowException();
            }

            if (itemToAdd == null)
            {

                StoreItem newItemAdd = new StoreItem(prod, quantity);
                _items.Add(newItemAdd);
                return newItemAdd;
            }
            else
            {
                itemToAdd.Quantity = itemToAdd.Quantity + quantity;
                return itemToAdd;
            }
        }
        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            var existingItem = FindStoreItemById(id);

            if (existingItem != null)
            {
                if (existingItem.Quantity - quantity < 0)
                {
                    existingItem.Quantity = (0);
                }
                else
                {
                    existingItem.Quantity = (existingItem.Quantity - quantity);
                }
                return existingItem;
            }
            else
            {
                throw new ProductDoesNotExistException();
            }
        }
        public StoreItem FindStoreItemById(int id)
        {
            if (id < 0)
            {
                throw new InvalidIdException();
            }
            var itemById =
                from e in _items
                where (e.Product.Id == id)
                select e;

            return itemById.FirstOrDefault();
        }

        public StoreItem DeleteStoreItem(int id)
        {
            var existingItem = FindStoreItemById(id);
            if (_items.Contains(existingItem))
            {
                _items.Remove(existingItem);
                return null;
            }
            else
            {
                return null;
            }
        }

        public List<StoreItem> GetAllProductsByName(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return null;
            }
            else
            {
                List<StoreItem> templist = new List<StoreItem>();
                char[] chars = key.ToCharArray();
                for (int i = 0; i < _items.Count; i++)
                {
                    for (int j = 0; j < chars.Length; j++)
                    {
                        char[] lichars = _items[i].Product.Name.ToCharArray();
                        if (chars[j] != lichars[j])
                        {
                            break;
                        }
                        if (j == chars.Length - 1)
                        {
                            templist.Add(_items[i]);
                        }

                    }

                }
                return templist;

            }
        }

        public List<StoreItem> GetAllProductsByQuantity()
        {
            _items = _items.OrderBy(x => x.Quantity).ToList();


            return _items;
        }

        public List<StoreItem> GetAllProductsByPrice()
        {
            _items = _items.OrderBy(x => x.Product.Price).ToList();


            return _items;

        }

    }
}
