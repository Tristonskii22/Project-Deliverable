﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions
{
    public class InventoryItemStockTooLowException: Exception
    {
        public static void InventoryStockTooLow()
        {
            try
            {
                throw new Exception("error");
            }
            catch
            {
                Console.WriteLine("Inventory Item stock Too Low");
            }
        }
    }
}
