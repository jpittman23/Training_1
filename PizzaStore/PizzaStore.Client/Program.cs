using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
    class Program
    {
        static void Main()
        {
            Welcome();
        }

        static void Welcome()
        {
            System.Console.WriteLine("Welcome to the Pizza Zone - Home of the best pizza ever made");
            System.Console.WriteLine("Please make a selection");
            System.Console.WriteLine();

            //array
            //string[] cart1 = { "", "", "" }; //initial values
            //string[] cart2 = new string[3]; //default values
            //string[] cart3 = new[] { "", "", "" }; //initial values for custom datatypes or earlies c# versions

            //list
            //List<string> cart4 = new List<string>{"", "", ""};//initial values
            //List<string> cart5 = new List<string>();//default values
            List<Pizza> cart6 = new List<Pizza>();

            //Menu(cart2);
            //Menu2(cart6);

            var startup = new PizzaStore.Client.Startup();
            var user = new User();
            var store = new Store();
            
            //var order = startup.CreateOrder(user , store)
            // if (order != null)
            // {
            //     Menu3(order);
            // }
            // else
            // {
            //     System.Console.WriteLine("We are experiencing some technical difficulties right now, please try again later");
            // }

            try
            {
                Menu3(startup.CreateOrder(user , store));
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
/*
        static void Menu2(List<Pizza> cart)
        {
            var exit = false;
            var number = 0;
            var startup = new PizzaStore.Client.Startup();

            do
            {

                if (number < 10)
                {
                    System.Console.WriteLine("Select 1 for Cheese");
                    System.Console.WriteLine("Select 2 for pepperoni");
                    System.Console.WriteLine("Select 3 for Hawaiian");
                    System.Console.WriteLine("Select 4 for Custom options");
                    System.Console.WriteLine("Select 5 for show cart");
                    System.Console.WriteLine("Select 6 for exit");
                    System.Console.WriteLine();

                    int select;

                    int.TryParse(Console.ReadLine(), out select);

                    switch (select)
                    {
                        case 1:
                            var p = startup.CreatePizza("Large", "Stuffed Crust", new List<string> { "Cheese" });
                            cart.Add(p);
                            number += 1;
                            System.Console.WriteLine("Cheese pizza added to cart");
                            System.Console.WriteLine();
                            break;
                        case 2:
                            cart.Add(startup.CreatePizza("Large", "Stuffed Crust", new List<string> { "Pepperoni" }));
                            number += 1;
                            System.Console.WriteLine("Pepperoni pizza added to cart");
                            System.Console.WriteLine();
                            break;
                        case 3:
                            cart.Add(startup.CreatePizza("Large", "Stuffed Crust", new List<string> { "Hawaiian" }));
                            number += 1;
                            System.Console.WriteLine("Hawaiian pizza added to cart");
                            System.Console.WriteLine();
                            break;
                        case 4:
                            cart.Add(startup.CreatePizza("Large", "Stuffed Crust", new List<string> { "Custom" }));
                            number += 1;
                            System.Console.WriteLine("Custom pizza added to cart");
                            System.Console.WriteLine();
                            break;
                        case 5:
                            DisplayCart2(cart);
                            System.Console.WriteLine();
                            break;
                        case 6:
                            System.Console.WriteLine("Proceed to checkout");
                            System.Console.WriteLine();
                            exit = true;
                            break;
                    }
                }

                //DisplayCart(cart);
                //number++; displays the number before execution
                //++number; displays the number after execution
                else
                {
                    System.Console.WriteLine("You have reached the limit on pizzas you can order \nPlease call the store to place a bigger order or check out your cart");
                    System.Console.WriteLine();
                    DisplayCart2(cart);
                    exit = true;

                }

                System.Console.WriteLine();
            } while (!exit);
        }

        static void DisplayCart(string[] cart)
        {
            foreach (var pizza in cart)
            {
                System.Console.WriteLine(pizza);
            }

            //for(var i = 0; i < cart.Length - 1; i++)
            //{
            //    System.Console.WriteLine(cart[i]);
            //}
        }

        static void DisplayCart2(List<Pizza> cart)
        {
            foreach (var pizza in cart)
            {
                System.Console.WriteLine(pizza);
            }

            //for(var i = 0; i < cart.Length - 1; i++)
            //{
            //    System.Console.WriteLine(cart[i]);
            //}
        }
        */
        static void Menu3(Order cart)
        {
            var exit = false;

            do
            {
                Startup.PrintMenu();

                int select;

                int.TryParse(Console.ReadLine(), out select);

                switch (select)
                {
                    case 1:
                        cart.CreatePizza("Large", "Stuffed Crust", new List<string> { "Cheese" });
                        System.Console.WriteLine("Cheese pizza added to cart");
                        System.Console.WriteLine();
                        break;
                    case 2:
                        cart.CreatePizza("Large", "Stuffed Crust", new List<string> { "Pepperoni" });
                        System.Console.WriteLine("Pepperoni pizza added to cart");
                        System.Console.WriteLine();
                        break;
                    case 3:
                        cart.CreatePizza("Large", "Stuffed Crust", new List<string> { "Hawaiian" });
                        System.Console.WriteLine("Hawaiian pizza added to cart");
                        System.Console.WriteLine();
                        break;
                    case 4:
                        cart.CreatePizza("Large", "Stuffed Crust", new List<string> { "Custom" });
                        System.Console.WriteLine("Custom pizza added to cart");
                        System.Console.WriteLine();
                        break;
                    case 5:
                        var fmr = new FileManager();
                        System.Console.WriteLine("Here are the items in your cart:");
                        DisplayCart3(fmr.Read());
                        System.Console.WriteLine();
                        break;
                    case 6:
                        var fmw = new FileManager();
                        fmw.Write(cart);
                        System.Console.WriteLine("Proceed to checkout");
                        System.Console.WriteLine();
                        exit = true;
                        break;
                }
                System.Console.WriteLine();
            } while (!exit);
        }
        static void DisplayCart3(Order cart)
        {
            foreach (var pizza in cart.Pizzas)
            {
                System.Console.WriteLine(pizza);
            }

            //for(var i = 0; i < cart.Length - 1; i++)
            //{
            //    System.Console.WriteLine(cart[i]);
            //}
        }
    }
}

