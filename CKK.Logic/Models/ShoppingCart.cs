﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer _customer;
        private ShoppingCartItem _product1;
        private ShoppingCartItem _product2;
        private ShoppingCartItem _product3;
        public ShoppingCart (Customer cust)
        {
            _customer = cust;
        }
        public int GetCustomerId()
        {
            return _customer.GetId();
        }
        public ShoppingCartItem GetProductById(int id)
        {
            if(_product1.GetProduct().GetId() == id)
            {
                return _product1;
            }
            if (_product2.GetProduct().GetId() == id)
            {
                return _product2;
            }
            if (_product3.GetProduct().GetId() == id)
            {
                return _product3;
            }
            return null;
        }
        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            if(quantity < 1)
            {
                return null;
            }
            if (_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
            {
                _product1.SetQuantity(_product1.GetQuantity() + quantity);
                return _product1;
            }
            if (_product1 == null)
            {
                _product1 = new ShoppingCartItem(prod, quantity);
                return _product1;
            }
            else if (_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
            {
                _product2.SetQuantity(_product2.GetQuantity() + quantity);
                return _product2;
            }
            if (_product2 == null)
            {
                _product2 = new ShoppingCartItem(prod, quantity);
                return _product2;
            }
            else if (_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
            {
                _product3.SetQuantity(_product3.GetQuantity() + quantity);
            }
            if (_product3 == null)
            {
                _product3 = new ShoppingCartItem(prod, quantity);
                return _product3;
            }
            return null;
            
        }
        public ShoppingCartItem AddProduct(Product prod)
        {
            return AddProduct(prod, 1);
        }
        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            if (quantity < 1)
            {
                return null;
            }
            if (_product1 !=null && _product1.GetProduct().GetId() == prod.GetId())
            {
                _product1.SetQuantity(_product1.GetQuantity() - quantity);
                if (_product1.GetQuantity() < 1)
                {
                    return null;
                }
                return _product1;
            }
            else if (_product2 !=null && _product2.GetProduct().GetId() == prod.GetId())
            {
                _product2.SetQuantity(_product2.GetQuantity() - quantity);
                if (_product2.GetQuantity()<1)
                {
                    return null;
                }
                return _product2;
            }
            else if (_product3 !=null && _product3.GetProduct().GetId() == prod.GetId())
            {
                _product3.SetQuantity(_product3.GetQuantity() - quantity);
                if (_product3.GetQuantity() < 1)
                {
                    return null;
                }
                return _product3;
            }
            return null;
        }
        public decimal GetTotal()
        {
            var grandtotal = 0m;
            if (_product1 != null)
            {
                grandtotal += _product1.GetTotal();
            }
            else if (_product2 != null)
            {
                grandtotal += _product2.GetTotal();
            }
            else if (_product3 != null)
            {
                grandtotal += _product3.GetTotal();
            }
            return grandtotal;
        }
        public ShoppingCartItem GetProduct(int productNumber)
        {
            if (productNumber ==1)
            {
                return _product1;
            }
            else if (productNumber == 2)
            {
                return _product2;
            }
            else if (productNumber ==3)
            {
                return _product3;
            }
            return null;
        }
    }
}
