using CKK.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    [Serializable]
    public class ShoppingCartItem : InventoryItem
    {
        //private int _quantity;
        //private Product _product;


        public ShoppingCartItem(Product _product, int _quantity)
        {
            Quantity = _quantity;
            Product = _product;
        }
        
        public decimal GetTotal()
        {
            return Product.GetPrice() * Quantity;
        }
    }

}
