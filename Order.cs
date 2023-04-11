using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richard_Pizzaria_UML2
{
    public class Order
    {
        public int _orderId;
        public Customer _customer;
        public Pizza _pizza;
        public double _totalPrice;

        public Order()
        {
            _orderId = orderId;
            _customer = customer;
            _pizza = pizza;
            _totalPrice = totalPrice;
        }

        public int orderId { get; set; }
        public Customer customer { get; set; }
        public Pizza pizza { get; set; }
        public double totalPrice { get; set; }

        public double Tax = 1.20;
        public int Delivery = 35;


        public override string ToString()
        {
            return 
                
                $" - Ordre nr: {orderId}\n" +
                $" - Customer: {customer}\n" +
                $" - Pizza: {pizza}" +
                $" Total price: {totalPrice}";
        }

        public void CalculateTotalPrice()
        {
            totalPrice = (pizza.pizzaPrice * Tax) + Delivery;
        }
    }
}
