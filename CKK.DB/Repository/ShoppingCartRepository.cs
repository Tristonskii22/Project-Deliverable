﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.DB.Interfaces;
using CKK.Logic.Models;

namespace CKK.DB.Repository
{
    class ShoppingCartRepository : IShoppingCartRepository
    {
        public int Add(ShoppingCartItem entity)
        {
            throw new NotImplementedException();
        }

        public ShoppingCartItem AddToCart(int ShoppingCartId, int ProductId, int quantity)
        {
            throw new NotImplementedException();
        }

        public int ClearCart(int ShoppingCartId)
        {
            throw new NotImplementedException();
        }

        public List<ShoppingCartItem> GetProducts(int ShoppingCartId)
        {
            throw new NotImplementedException();
        }

        public decimal GetTotal(int ShoppingCartId)
        {
            throw new NotImplementedException();
        }

        public void Ordered(int ShoppingCartId)
        {
            throw new NotImplementedException();
        }

        public int Update(ShoppingCartItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
