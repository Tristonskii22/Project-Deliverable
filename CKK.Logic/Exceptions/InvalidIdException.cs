﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions
{
    class InvalIdIdException
    {
        public static void EntityId()
        {
            try
            {
                throw new Exception("Error");
            }
            catch
            {
                Console.WriteLine("Invalid Entry");
            }
        }
    }
}