using BookSaleWebsite;
using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repository
{
    public class OrdersRepository : IRepository<Orders>
    {
        BookSaleEntities ordersContext;
        

        public OrdersRepository()
        {
            ordersContext = new BookSaleEntities();
        }

        public OrdersRepository(BookSaleEntities entities)
        {
            // TODO: Complete member initialization
            this.ordersContext = entities;
        }

        public List<Orders> GetAll()
        {
            List<Orders> allOrders = ordersContext.Order.ToList();
            return allOrders;
        }

        public Orders Find(int ID)
        {
            var order = ordersContext.Order.Find(ID);
            return order;
        }

        public int Add(Orders entity)
        {
            ordersContext.Order.Add(entity);
            ordersContext.SaveChanges();

            return entity.OrdersID;
        }

        public void Update(Orders entity)
        {
            var order = ordersContext.Order.Find(entity.OrdersID);

            if ( order != null)
            {
                order.OrdersID = entity.OrdersID;
                order.PaymentID = entity.PaymentID;

                ordersContext.SaveChanges();
            }
        }

        public void Delete(Orders entity)
        {
            var order = ordersContext.Order.Find(entity.OrdersID);
             if ( order != null)
             {
                 ordersContext.Order.Remove(entity);

                 ordersContext.SaveChanges();
             }

        }
    }
}
