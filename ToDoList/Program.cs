using System.Collections.Generic;
using System;
using ToDoList.Models;

namespace ToDoList.Models
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the To Do List.");

                Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
                string userResponse = Console.ReadLine();
                if (userResponse == "Add") 
                {
                    Console.WriteLine("Please enter the description for the new item.");
                    string newItemDescription = Console.ReadLine();
                    Item itemOne = new Item(newItemDescription);
                    Console.WriteLine(newItemDescription + " has been added to your list.");
                    Main();
                }
                else if (userResponse == "View")
                {
                    List<Item> newList = Item.GetAll();
                    foreach(Item X in newList)
                    {
                    string toDoTask = X.GetDescription();
                    Console.WriteLine(toDoTask);  
                    } 
                    Main();   
                } 
              else {
                  Console.WriteLine("Thank you for using List!");
                   }
         
        }
    }
}