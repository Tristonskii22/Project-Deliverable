using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CKK.Logic.Interfaces
{
    public interface IStore
    {
        public StoreItem AddStoreItem(Product prod, int quantity);
        public StoreItem RemoveStoreItem(int id, int quantity);
        public StoreItem FindStoreItemById(int id);
        public List<StoreItem> GetStoreItems();
        public StoreItem DeleteStoreItem(int id);
        public List<StoreItem> GetAllProductsByName(string key);
        public List<StoreItem> GetAllProductsByQuantity();
        public List<StoreItem> GetAllProductsByPrice();
    }
}
