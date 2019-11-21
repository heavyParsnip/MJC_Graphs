using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJC_Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize variables
            Graph rooms = new Graph();
            string currentRoom = "courtyard";
            string input;

            //Room loop
            while (currentRoom != "exit")
            {
                Console.WriteLine($"\nYou are currently in the {currentRoom.ToUpper()}");
                List<string> currentAdjacency = rooms.GetAdjacentList(currentRoom);
                Console.Write($"\tNearby are: ");

                foreach(string r in currentAdjacency)
                {
                    Console.Write($"\t{r} ");
                }

                Console.WriteLine("\n\tWhere would you like to go?");
                input = Console.ReadLine().ToLower();

                if (rooms.IsConnected(currentRoom, input) == true)
                {
                    currentRoom = input;
                }
                else
                {
                    while (rooms.IsConnected(currentRoom, input) == false)
                    {
                        Console.WriteLine("Sorry, that is not an adjacent room.");
                        Console.WriteLine("\n\tWhere would you like to go?");
                        input = Console.ReadLine().ToLower();
                        if (rooms.IsConnected(currentRoom, input) == true)
                        {
                            currentRoom = input;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("\nYou have successfully escaped.");
            Console.WriteLine("Press ENTER to continue. . .");
            Console.ReadLine();
        }
    }
}
