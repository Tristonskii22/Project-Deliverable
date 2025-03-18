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
    [Serializable]
    
    public class Product : Entity
    {
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if(value >= 0)
                    price = value;
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        //public int Id;
        //public string Name;
        public decimal price { get; set; }

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
       
    }
}
