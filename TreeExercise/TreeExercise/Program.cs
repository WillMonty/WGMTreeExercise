using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    /*
    William Montgomery Tree Exercise
    Creates and prints a tree with a user specified number of levels.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("William Montgomery NeuroScouting Tree Exercise");
            int userLevels = 0; //The number of levels the user will specify

            bool gettingInput = true;
            while (gettingInput) //Loop to continue asking for input until correct
            {
                Console.Write("Please enter the number of levels you want the tree to be: ");
                Int32.TryParse(Console.ReadLine(), out userLevels);

                if (userLevels <= 0)
                {
                    Console.WriteLine("You can't have a tree with 0 or fewer levels! Try again.\n");
                    continue;
                }
                else
                {
                    gettingInput = false;
                }
            }

            //Create tree
            Tree myTree = new Tree(userLevels);
            myTree.Print();
            Console.WriteLine("\n");

            //Print out tree node by node in case print function is hard to read after some amount of levels
            Console.WriteLine("All nodes in the tree sequentially:");

            for(int i = 1; i < myTree.AllNodes.Length - 1; i++)
            {
                Console.Write(myTree.AllNodes[i].Data + ", ");
            }
            Console.Write(myTree.AllNodes[myTree.AllNodes.Length - 1].Data);

            Console.WriteLine();

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
