using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    
    public class Product : Entity
    {
        public decimal Price
        {
            get
            {
                return Price;
            }
            set
            {
                if(value >= 0)
                    Price = value;
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        //public int Id;
        //public string Name;
        //public decimal Price;

        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            Id = id;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public decimal GetPrice()
        {
            return Price;
        }
        public void SetPrice(decimal price)
        {
            Price = price;
        }
    }
}
