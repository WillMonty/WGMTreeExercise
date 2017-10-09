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
            Console.Write("Please enter the number of levels you want the tree to be: ");

            int userLevels;
            Int32.TryParse(Console.ReadLine(), out userLevels);

            if(userLevels == 0)
            {
                Console.WriteLine("You can't have a tree with 0 or fewer levels! Try again.\n");
            }

            Tree myTree = new Tree(userLevels);

            myTree.Print();
        }
    }
}
