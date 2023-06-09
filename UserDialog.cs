﻿using Richard_Pizzaria_UML2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richard_Pizzaria_UML2
{
    public class UserDialog
    {
        MenuCatalog MenuCatalog;
        CustomerCatalog CustomerCatalog;
        OrderCatalog OrderCatalog;
        public UserDialog(MenuCatalog menuCatalog, CustomerCatalog customerCatalog, OrderCatalog orderCatalog)
        {
            MenuCatalog = menuCatalog;
            CustomerCatalog = customerCatalog;
            OrderCatalog = orderCatalog;
        }

        Pizza PrintPizza()
        {
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("|      Pizza Menu     |");
            Console.WriteLine("-----------------------");
            MenuCatalog.PrintMenu();
            return null;
        }
        Customer CustomerPrint()
        {
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("|    Customer List    |");
            Console.WriteLine("-----------------------");
            CustomerCatalog.CustomerPrint();
            return null;
        }

        Order OrderPrint()
        {
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("|     Order List      |");
            Console.WriteLine("-----------------------");
            OrderCatalog.OrderPrint();
            return null;
        }

        Pizza SearchPizza()
        {
            Pizza pizzaItem = new Pizza();
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("|    Search Pizza     |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();

            Console.Write("Search pizza by full name: ");
          
            string input = "";
            try
            {
                input = Convert.ToString(Console.ReadLine());
                pizzaItem.pizzaName = input;

            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }
            return pizzaItem;
        }

        Customer SearchCustomer()
        {
            Customer customerItem = new Customer();
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("|   Search customer   |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();

            Console.Write("Search Customer by full name: ");

            string input = "";
            try
            {
                input = Convert.ToString(Console.ReadLine());
                customerItem.customerName = input;

            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }
            return customerItem;
        }

        Order SearchOrder()
        {
            Order orderItem = new Order();
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("|    Search Orders    |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();

            Console.Write("Search Orders by Id number: ");
            string input = "";
            try
            {
                input = Console.ReadLine();
                orderItem.orderId = Int32.Parse(input);

            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse 'input' - Message: {e.Message}");
                throw;
            }
            return orderItem;
        }

        Pizza UpdatePizza()
            {
            Pizza pizzaItem = new Pizza();
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("|    Update Pizza     |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            MenuCatalog.PrintMenu();

            Console.Write("Enter number you want to update: ");
            pizzaItem.pizzaId = Int32.Parse(Console.ReadLine());

            string input = "";
            Console.Write("Enter new name: ");
            try
            {
                input = Console.ReadLine();
                pizzaItem.pizzaName = input;
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            input = "";
            Console.Write("Enter new price: ");
            try
            {
                input = Console.ReadLine();
                pizzaItem.pizzaPrice = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }
            return pizzaItem;
        }

        Order UpdateOrder()
        {
            Order orderItem = new Order();
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("|    Update Order     |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            OrderCatalog.OrderPrint();

            Console.Write("Enter number you want to update: ");
            orderItem.orderId = Int32.Parse(Console.ReadLine());

            string input = "";
            Console.Write("Enter new name: ");
            try
            {
                input = Console.ReadLine();
                orderItem.name = input;
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            input = "";
            Console.Write("Enter new price: ");
            try
            {
                input = Console.ReadLine();
                orderItem.price = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }
            return orderItem;
        }
        Customer UpdateCustomer()
        {
            Customer customerItem = new Customer();
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("|   Update Customer   |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            CustomerCatalog.CustomerPrint();

            Console.Write("Enter number you want to update: ");
            customerItem.customerId = Int32.Parse(Console.ReadLine());

            string input = "";
            Console.Write("Enter new name: ");
            try
            {
                input = Console.ReadLine();
                customerItem.customerName = input;
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            input = "";
            Console.Write("Enter new Phone number: ");
            try
            {
                input = Console.ReadLine();
                customerItem.customerPhone = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            input = "";
            Console.Write("Enter new age: ");
            try
            {
                input = Console.ReadLine();
                customerItem.customerAge = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            input = "";
            Console.Write("Enter new Id: ");
            try
            {
                input = Console.ReadLine();
                customerItem.customerId = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            return customerItem;
        }
        Pizza GetNewPizza()
        {
            Pizza pizzaItem = new Pizza();
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("|   Creating Pizza    |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.Write("Enter name: ");
            pizzaItem.pizzaName = Console.ReadLine();

            string input = "";
            Console.Write("Enter price: ");
            try
            {
                input = Console.ReadLine();
                pizzaItem.pizzaPrice = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            input = "";
            Console.Write("Enter pizza number: ");
            try
            {
                input = Console.ReadLine();
                pizzaItem.pizzaId = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            return pizzaItem;
        }

        Customer CreateNewCustomer()
        {
            Customer customerItem = new Customer();
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("|  Creating Customer  |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.Write("Enter name: ");
            customerItem.customerName = Console.ReadLine();

            string input = "";
            Console.Write("Enter Phone number: ");
            try
            {
                input = Console.ReadLine();
                customerItem.customerPhone = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            input = "";
            Console.Write("Enter customer age: ");
            try
            {
                input = Console.ReadLine();
                customerItem.customerAge = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }
            input = "";
            Console.Write("Enter customer id: ");
            try
            {
                input = Console.ReadLine();
                customerItem.customerId = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            return customerItem;
        }

        Order CreateNewOrder()
        {
            Order orderItem = new Order();
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("|   Creating Order    |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.Write("Enter the Id of the order: ");
            orderItem.orderId = Int32.Parse(Console.ReadLine());

            string input = "";
            Console.Write("Enter the name of the customer: ");
            try
            {
                input = Console.ReadLine();
                orderItem.name = input;
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            input = "";
            Console.Write("Enter the name of the pizza: ");
            try
            {
                input = Console.ReadLine();
                orderItem.pizza = input;
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            input = "";
            Console.Write("Enter the price of the pizza: ");
            try
            {
                input = Console.ReadLine();
                orderItem.price = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }
           
            return orderItem;
        }


        Pizza DeletePizza()
        {
            Pizza pizzaItem = new Pizza();
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("|    Delete Pizza     |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            MenuCatalog.PrintMenu();

            Console.Write("Enter number you want to delete: ");
            string input = "";
            try
            { 
                input = Console.ReadLine();
                pizzaItem.pizzaId = Int32.Parse(input);
            }
            catch (FormatException e) 
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }
            return pizzaItem;

        }

        Order DeleteOrder()
        {
            Order orderItem = new Order();
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("|    Delete Order     |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            OrderCatalog.OrderPrint();

            Console.Write("Enter number you want to delete: ");
            string input = "";
            try
            {
                input = Console.ReadLine();
                orderItem.orderId = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }
            return orderItem;

        }
        Customer DeleteCustomer()
        {
            Customer customerItem = new Customer();
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("|   Delete Customer   |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            CustomerCatalog.CustomerPrint();

            Console.Write("Enter number you want to delete: ");
            string input = "";
            try
            {
                input = Console.ReadLine();
                customerItem.customerId = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }
            return customerItem;

        }


        int MainMenuChoice(List<string> menuItems)
        {
            Console.Clear();

            Console.WriteLine("-----------------------");
            Console.WriteLine("| RICHARD'S PIZZAMENU |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();

            foreach (string choice in menuItems)
            {
                Console.WriteLine(choice);
            }

            Console.Write("Enter option#: ");
            string input = Console.ReadLine();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }

            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }
            return -1;
        }
        public void Run()
        {
            bool proceed = true;
            List<string> mainMenulist = new List<string>()
            {
                "     - PIZZA -    ",
                "0. Print Pizza Menu",
                "1. Create Pizza",
                "2. Update Pizza",
                "3. Search Pizza",
                "4. Delete Pizza",
                "",
                "   - CUSTOMER -    ",
                "5. Print Customer",
                "6. Create Customer",
                "7. Update Customer",
                "8. Search Customer",
                "9. Delete Customer",
                "",
                "     - ORDER -     ",
                "10. Print Orders",
                "11. Create Order",
                "12. Update Order",
                "13. Search Order",
                "14. Delete Orders",
                "",
                "15. quit",
            };

            while (proceed)
            {
                int MenuChoice = MainMenuChoice(mainMenulist);
                Console.WriteLine();
                switch (MenuChoice)
                {
                    case 0:
                        try
                        {
                            PrintPizza();
                            Console.Write("Hit any key to continue");
                            Console.ReadKey();
                        }
                        catch(Exception)
                        {
                            Console.WriteLine($"No pizza menu found");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 1:
                        try
                        {
                            Pizza pizza = GetNewPizza();
                            MenuCatalog.Create(pizza);
                            Console.WriteLine($"You created: {pizza}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No pizza created");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 2:
                        try
                        {
                            Pizza pizza = UpdatePizza();
                            MenuCatalog.Update(pizza);
                            Console.WriteLine($"You updated: {pizza}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No pizza updated");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 3:
                        try
                        {
                            Pizza pizza = SearchPizza();
                            MenuCatalog.SearchPizza(pizza);
                            //Console.WriteLine($"We found this: {pizza}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No pizza found");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 4:
                        try
                        {
                            Pizza pizza = DeletePizza();
                            MenuCatalog.Delete(pizza);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No pizza found");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 5:
                        try
                        {
                            CustomerPrint();
                            Console.Write("Hit any key to continue");
                            Console.ReadKey();
                        }
                        catch (Exception )
                        {
                            Console.WriteLine($"No customer list found");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 6:
                        try
                        {
                            Customer customer = CreateNewCustomer();
                            CustomerCatalog.Create(customer);
                            Console.WriteLine($"You created: {customer}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No customer created");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 7:
                        try
                        {
                            Customer customer = UpdateCustomer();
                            CustomerCatalog.UpdateCustomer(customer);
                            Console.WriteLine($"You updated: {customer}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No customer updated");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 8:
                        try
                        {
                            Customer customer = SearchCustomer();
                            CustomerCatalog.SearchCustomer(customer);
                            //Console.WriteLine($"We found this: {pizza}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No customer found");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 9:
                        try
                        {
                            Customer customer = DeleteCustomer();
                            CustomerCatalog.DeleteCustomer(customer);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No customer found");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        
                        break;
                    case 10:
                        try
                        {
                            OrderPrint();
                            Console.Write("Hit any key to continue");
                            Console.ReadKey();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No Order list found");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 11:
                        try
                        {
                            Order order = CreateNewOrder();
                            OrderCatalog.Create(order);
                            Console.WriteLine($"You created: {order}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No order created");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 12:
                        try
                        {
                            Order order = UpdateOrder();
                            OrderCatalog.UpdateOrder(order);
                            Console.WriteLine($"You updated: {order}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No order updated");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 13:
                        try
                        {
                            Order order = SearchOrder();
                            OrderCatalog.SearchOrder(order);
                            //Console.WriteLine($"We found this: {pizza}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No order found");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 14:
                        try
                        {
                            Order order = DeleteOrder();
                            OrderCatalog.DeleteOrder(order);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No order found");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 15:
                        proceed = false;
                        Console.WriteLine("Quitting");
                        break;
                    default:
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;



                }
            }

        }
    }
}