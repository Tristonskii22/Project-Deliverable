﻿using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int ShoppingCartId { get; set; }
    }
}