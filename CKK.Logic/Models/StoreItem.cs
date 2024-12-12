using CKK.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    [Serializable]
    public class StoreItem : InventoryItem
    {
        


        public StoreItem(Product _product, int _quantity)
        {
            Product = _product;
            Quantity = _quantity;
        }
        //public int GetQuantity()
        //{
        //    return _quantity;
        //}
        //public void SetQuantity(int quantity)
        //{
        //    _quantity = quantity;
        //}
        //public Product GetProduct()
        //{
        //    return _product;
        //}
        //public void SetProduct(Product product)
        //{
        //    _product = product;
        //}
    }
}
