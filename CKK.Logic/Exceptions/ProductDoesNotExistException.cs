﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions
{
    class ProductDoesNotExistException
    {
        public static void ProductDoesNotExist()
        {
            try
            {
                throw new Exception("Error");

            }
            catch
            {
                Console.WriteLine("This product does not exist");
            }
        }
    }
}