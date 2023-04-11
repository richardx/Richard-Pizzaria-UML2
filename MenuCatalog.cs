using System;
using System.Collections.Generic;
namespace Richard_Pizzaria_UML2
{
    public class MenuCatalog
    {
        List<Pizza> _pizzas;

        public MenuCatalog()
        {
            _pizzas = new List<Pizza>();
        }

        public void Create(Pizza p)
        {
            _pizzas.Add(p);
        }

        public void PrintMenu()
        {
            foreach (var p in _pizzas)
            {
                Console.WriteLine(p);
                Console.WriteLine("======================================");
            }
        }
        public Pizza Read(int number)
        {
            foreach (var p in _pizzas)
            {
                if (p.pizzaId == number)
                {
                    return p;
                }

            }
            return null;
        }
        public Pizza SearchPizza(Pizza pizza)
        {
            foreach (var p in _pizzas)
            {
                if (p.pizzaName == pizza.pizzaName)
                {
                    Console.WriteLine($"{p}");
                }
            }
            return null;
        }
        //string searchCriteria



        public void Update(Pizza pizza)
        {
            foreach (var p in _pizzas)
            {
                if (p.pizzaId == pizza.pizzaId)
                {
                    p.pizzaName = pizza.pizzaName;
                    p.pizzaPrice = pizza.pizzaPrice;
                }
            }
        }

        public void Delete(Pizza pizza)
        {
            foreach (var p in _pizzas)
            {
                if (p.pizzaId == pizza.pizzaId)
                {
                    pizza = p;
                    break;
                }

            }
            _pizzas.Remove(pizza);
        }
    }
}