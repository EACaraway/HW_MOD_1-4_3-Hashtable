using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace HW_Mod_1_4_HashTable
{
    class Program
    { 
        static void Main(string[] args)
        {   // creating a Hashtable using collection-initialzer syntax
            Hashtable userItems = new Hashtable();

            while (true)
            {               
                Console.WriteLine("1. Add item(s) to your list.");
                Console.WriteLine("2. Get a discription of your item.");
                Console.WriteLine("3. List all items.");
                Console.WriteLine("4. Exit.");               
                Console.Write("Choose a number: ");
                int.TryParse(Console.ReadLine(), out int userOption);

                switch (userOption)                
                {
                    case 1:
                        Console.Write("Please enter the number of items you would like to add to you list: ");
                        int.TryParse(Console.ReadLine(), out int numOfItems);
                        for (int i = 0; i < numOfItems; i++)
                        {
                            Console.Write("Enter an item name: ");
                            var itemInput = Console.ReadLine();
                            Console.Write("Enter a description for your item: ");
                            var descriptionInput = Console.ReadLine();
                            // Add to Hashtable userItems user item to key and user description to value as a pair.
                            userItems.Add(itemInput, descriptionInput);
                        }
                        break;
                    
                    case 2:
                        Console.Write("What is the name of your item? ");
                        var itemName = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"The item named {itemName} has a description of: {userItems[itemName]}.");
                        Console.ResetColor();
                        break;
                    
                    case 3:
                        Console.Write($"The items in the list are: ");
                        // list all the Keys (item names) in the Hashtable.
                        foreach (DictionaryEntry item in userItems)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($" {item.Key};");
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                        break;
                    
                    case 4:
                        System.Environment.Exit(0);
                        break;
                    
                    default:
                        Console.WriteLine("Not a valid option");
                        break;
                }
            }
                                   
        }
    }
}
