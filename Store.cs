using Richard_Pizzaria_UML2;
using System;

namespace Richard_Pizzaria_UML2
{
    public class Store
    {
        MenuCatalog menuCatalog;
        CustomerCatalog customerCatalog;

        public Store()
        {
            menuCatalog = new MenuCatalog();
            customerCatalog = new CustomerCatalog();
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


            //Order o = new Order() { orderId = 1, customerName = "Dorte Brønd", };
            //Console.WriteLine();
            //int pizzaToBeFound = 2;
            //Console.WriteLine($"Finding Pizza {pizzaToBeFound}");
            //Pizza foundPizza = menuCatalog.Read(pizzaToBeFound);
            //Console.WriteLine(foundPizza);

            //Console.WriteLine();
            //string searchCriteria = "Skinke";
            //Console.WriteLine($"Finding Pizza: {searchCriteria}");
            //foundPizza = menuCatalog.SearchPizza(searchCriteria);
            //Console.WriteLine(foundPizza);

            //Console.WriteLine();
            //Console.WriteLine($"Updating Pizza #{foundPizza.pizzaId}");
            //foundPizza.pizzaName += " (Updated)";
            //menuCatalog.Update(foundPizza);

            //Console.WriteLine();
            //menuCatalog.PrintMenu();

            //Console.WriteLine();
            //int pizzaToBeDeleted = 0;
            //Console.WriteLine($"Deleting pizza#: {pizzaToBeDeleted}");
            //menuCatalog.Delete(pizzaToBeDeleted);
            //Console.WriteLine();

            //menuCatalog.PrintMenu();



            //Console.WriteLine("");
            //Console.WriteLine("Vælg en pizza 1-3: ");
            //int pizzaToBeFound = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Finding Pizza {pizzaToBeFound}...");
            //Console.WriteLine();
            //Pizza foundPizza = menuCatalog.Read(pizzaToBeFound);
            //Console.WriteLine(foundPizza);

            //Console.WriteLine("");
            //Console.WriteLine("Søg efter pizza navn: ");
            //string searchCriteria = Convert.ToString(Console.ReadLine());
            //Console.WriteLine($"Finding Pizza starting with: {searchCriteria}");
            //foundPizza = menuCatalog.SearchPizza(searchCriteria);
            //Console.WriteLine(foundPizza);

            //Console.WriteLine();
            //Console.WriteLine($"Updating Pizza #{foundPizza.Number}");
            //foundPizza.pizzaname += " (Updated)";
            //menuCatalog.Update(foundPizza);

            //Console.WriteLine();
            //menuCatalog.PrintMenu();

            //Console.WriteLine("Indtast Hvilket nummer 1-3 af pizza der skal slettes: ");
            //int pizzaToBeDeleted = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Deleting pizza#: {pizzaToBeDeleted}");
            //menuCatalog.Delete(pizzaToBeDeleted);
            //Console.WriteLine($"Pizza {pizzaToBeDeleted} is deleted.");

            //menuCatalog.PrintMenu();

        }
        public void Run()
        {
            new UserDialog(menuCatalog, customerCatalog).Run();
            //new UserDialog(customerCatalog).Run();
        }
    }
}