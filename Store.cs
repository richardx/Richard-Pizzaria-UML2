using Richard_Pizzaria_UML2;
using System;
using System.Data;

namespace Richard_Pizzaria_UML2
{
    public class Store
    {
        MenuCatalog menuCatalog;
        CustomerCatalog customerCatalog;
        OrderCatalog orderCatalog;

        public Store()
        {
            menuCatalog = new MenuCatalog();
            customerCatalog = new CustomerCatalog();
            orderCatalog = new OrderCatalog();
            Menu();
            Run();
        }
        public void Menu()
        {
            Pizza p = new Pizza() {pizzaId = 1, pizzaName = "hawaii", pizzaPrice = 60}; 
            menuCatalog.Create(p);
            p = new Pizza() {pizzaId = 2, pizzaName = "calzone", pizzaPrice = 55}; 
            menuCatalog.Create(p);
            p = new Pizza() {pizzaId = 3, pizzaName = "skinke", pizzaPrice = 65}; 
            menuCatalog.Create(p);

            Customer c = new Customer() { customerId = 1, customerName = "Hans Hansen", customerAge = 54, customerPhone = 34549912};
            customerCatalog.Create(c);
            c = new Customer() { customerId = 2, customerName = "Dorte Brønd", customerAge = 42, customerPhone = 88657112 };
            customerCatalog.Create(c);
            c = new Customer() { customerId = 3, customerName = "Abraham sofus", customerAge = 35, customerPhone = 15677721 };
            customerCatalog.Create(c);

            Order o = new Order() { orderId = 1, name = "Hans Hansen", pizza = "Hawaii", price = 70};
            orderCatalog.Create(o);
            o = new Order() { orderId = 2, name = "Eva Jørgensen", pizza = "Ananas og skinke", price = 69 };
            orderCatalog.Create(o);
            o = new Order() { orderId = 3, name = "Momo Harun", pizza = "Kebab", price = 42 };
            orderCatalog.Create(o);

        }
        public void Run()
        {
            new UserDialog(menuCatalog, customerCatalog, orderCatalog).Run();
            //new UserDialog(customerCatalog).Run();
        }
    }
}