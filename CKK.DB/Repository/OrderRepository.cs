using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.DB.Interfaces;
using CKK.Logic.Models;

namespace CKK.DB.Repository
{
    class OrderRepository : IOrderRepository
    {
        public int Add(Order entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderByCustomerId(int Id)
        {
            throw new NotImplementedException();
        }

        public int Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
