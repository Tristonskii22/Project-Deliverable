using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Interfaces
{
    interface IShoppingCart
    {
        public int GetCustomerId();
        public ShoppingCartItem AddProduct(Product prod, int quant);
        public ShoppingCartItem RemoveProduct(int id, int quant);
        public decimal GetTotal();
        public ShoppingCartItem GetProductById(int id);
        public List<ShoppingCartItem> GetProducts();
    }
}
