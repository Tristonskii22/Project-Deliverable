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
            if (id < 0)
            {
                throw new InvalidIdException();
            }

            return _items.Find(x => x.Product.GetId() == id);
        }
        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            if(quantity <= 0)
            {
                throw new InventoryItemStockTooLowException();
            }
            var AddItem = GetProductById(prod.GetId());
            if (AddItem != null)
            {
                AddItem.Quantity = AddItem.Quantity + quantity;
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
                throw new ArgumentOutOfRangeException();
            }
            var RemoveItem = GetProductById(id);
            if (RemoveItem != null)
            {
                if(RemoveItem.Quantity - quantity <= 0)
                {
                    RemoveItem.Quantity = 0;
                    _items.Remove(RemoveItem);
                    return RemoveItem;
                }
                RemoveItem.Quantity = RemoveItem.Quantity - quantity;
                return RemoveItem;
            }
            throw new ProductDoesNotExistException();
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
