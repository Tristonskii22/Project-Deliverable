using CKK.Logic.Exceptions;
using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CKK.Logic.Interfaces
{
    public abstract class InventoryItem
    {
        public Product product { get; set; }

        public int Quantity
        {
            get
            {
                return Quantity;
            }
            set
            {
                if (value >= 0)
                    value = Quantity;
                else
                {
                    InventoryItemStockTooLowException.InventoryStockTooLow();
                }

            }
        }
    }
}
