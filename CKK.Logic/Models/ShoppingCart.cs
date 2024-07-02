using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart : IShoppingCart
    {
        public Product Products { get; set; }
        public Customer Customer
        {
            get; set;
        }
        private List<ShoppingCartItem> _items = new List<ShoppingCartItem>();
        //private ShoppingCartItem _product1;
        //private ShoppingCartItem _product2;
        //private ShoppingCartItem _product3;
        public ShoppingCart (Customer cust)
        {
            Customer = cust;
        }
        public int GetCustomerId()
        {
            return Customer.GetId();
        }
        public ShoppingCartItem GetProductById(int id)
        {
            return _items.Find(x => x.GetProduct().GetId() == id);
            if (id < 0)
            {
                InvalidIdException.EntityId();
            }
        }
        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            if(quantity <= 0)
            {
                InventoryItemStockTooLowException.InventoryStockTooLow();
            }
            var AddItem = GetProductById(prod.GetId());
            if (AddItem != null)
            {
                AddItem.SetQuantity(AddItem.GetQuantity() + quantity);
                return AddItem;
            }
            ShoppingCartItem itemadd = new ShoppingCartItem(prod, quantity);
            _items.Add(itemadd);
            return itemadd;
            
        }
        public ShoppingCartItem AddProduct(Product prod)
        {
            return AddProduct(prod, 1);
        }
        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            if (quantity < 0)
            {
                ProductDoesNotExistException.ProductDoesNotExist();
            }
            var RemoveItem = GetProductById(id);
            if (RemoveItem != null)
            {
                if(RemoveItem.GetQuantity() - quantity <= 0)
                {
                    RemoveItem.SetQuantity(0);
                    _items.Remove(RemoveItem);
                    return RemoveItem;
                }
                RemoveItem.SetQuantity(RemoveItem.GetQuantity() - quantity);
                return RemoveItem;
            }
            throw new ArgumentOutOfRangeException();
        }
        public decimal GetTotal()
        {
            var grandtotal = 0m;
            foreach (ShoppingCartItem product in _items)
            {
                grandtotal += product.GetTotal();
            }
            return grandtotal;
        }
        public List <ShoppingCartItem> GetProducts()
        {
            return _items;
        }
    }
}
