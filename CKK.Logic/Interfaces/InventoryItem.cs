﻿using CKK.Logic.Exceptions;
using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CKK.Logic.Interfaces
{
    [Serializable]
    public abstract class InventoryItem
    {
        public Product Product { get; set; }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value >= 0)
                    quantity = value;
                else
                {
                    throw new InventoryItemStockTooLowException();
                }

            }
        }
        private int quantity;
    }
}
