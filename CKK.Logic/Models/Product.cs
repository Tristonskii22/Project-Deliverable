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
        public new int Id { get; set; }
        public new string? Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}

