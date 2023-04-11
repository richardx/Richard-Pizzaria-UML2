﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richard_Pizzaria_UML2
{
    public class OrderCatalog
    {
       
        List<Order> _order;
        public OrderCatalog()
        {
            _order = new List<Order>();
        }

        public void Create(Order o)
        {
            _order.Add(o);
        }

        public void OrderPrint()
        {
            foreach (var o in _order)
            {
                Console.WriteLine(o);
                Console.WriteLine("======================================");
            }
        }

        public Order SearchOrder(Order order)
        {
            foreach (var o in _order)
            {
                if (o.orderId == order.orderId)
                {
                    Console.WriteLine($"{o}");
                }
            }
            return null;

        }

        //public void UpdateOrder(Order order, Customer customer, Pizza pizza)
        //{
        //    foreach (var o in _order)
        //    {
        //        if (o.orderId == order.orderId)
        //        {
        //            o.customerName = Order.customerName;
        //            o.customerId = customer.customerId;
        //        }
        //    }
        //}


    }
}
