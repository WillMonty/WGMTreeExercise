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
            while (gettingInput)
            {
                Console.Write("Please enter the number of levels you want the tree to be: ");
                Int32.TryParse(Console.ReadLine(), out userLevels);

                if (userLevels <= 0)
                {
                    Console.WriteLine("You can't have a tree with 0 or fewer levels! Try again.\n");
                    continue;
                }

                if(userLevels > 0)
                {
                    gettingInput = false;
                }
            }
            Tree myTree = new Tree(userLevels);
            Console.WriteLine(myTree.Root.Left.Right.Data);
            myTree.Print();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
