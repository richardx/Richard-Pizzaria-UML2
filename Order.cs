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
        public string _name;
        public string _pizza;
        public double _totalPrice;
        public int _price;

        public Order()
        {
            _orderId = orderId;
            _name = name;
            _pizza = pizza;
            _price = price;
            _totalPrice = totalPrice;
        }

        public int orderId { get; set; }
        public string name { get; set; }
        public string pizza { get; set; }
        public double totalPrice { get; set; }
        public int price { get; set; }

        public double Tax = 1.20;
        public int Delivery = 35;


        public override string ToString()
        {
            return 
                
                $" - Ordre nr: {orderId}\n" +
                $" - Customer: {name}\n" +
                $" - Pizza: {pizza}" +
                $" Total price: {price*2}";
        }

        
    }
}
