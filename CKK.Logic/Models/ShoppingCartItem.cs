using CKK.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem : InventoryItem
    {
        private int _quantity;
        private Product _product;


        public ShoppingCartItem(Product product, int quantity)
        {
            _quantity = quantity;
            _product = product;
        }
        public int GetQuantity()
        {
            return _quantity;
        }
        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }
        public Product GetProduct()
        {
            return _product;
        }
        public void SetProduct(Product product)
        {
            _product = product;
        }
        public decimal GetTotal()
        {
            return _product.GetPrice() * _quantity;
        }
    }
    
}
