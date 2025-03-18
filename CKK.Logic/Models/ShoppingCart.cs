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
        private List<ShoppingCartItem> ShoppingCartItems { get; set; } = new List<ShoppingCartItem>();
        
        public ShoppingCart (Customer cust)
        {
            Customer = cust;
        }
        public int CustomerId {  get; set; }
        public int ShoppingCartId { get; set; }
        public ShoppingCartItem GetProductById(int id)
        {
            if (id < 0)
            {
                throw new InvalidIdException();
            }

            return ShoppingCartItems.Find(x => x.Product.GetId() == id);
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
            ShoppingCartItems.Add(itemadd);
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
                    ShoppingCartItems.Remove(RemoveItem);
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
            foreach (ShoppingCartItem product in ShoppingCartItems)
            {
                grandtotal += product.GetTotal();
            }
            return grandtotal;
        }
        public List <ShoppingCartItem> GetProducts()
        {
            return ShoppingCartItems;
        }
    }
}
