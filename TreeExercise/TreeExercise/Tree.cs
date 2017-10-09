using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    /*
    William Montgomery Tree
    Creates a tree structure of integer containing nodes.
    Left children in the tree are the sum of its parent's value and its parent's left neighbor's values.
    Right children in the tree are the sum of its parent's and its parent's right neighbor's values. 
    */
    class Tree
    {
        private Node root;
        private int levels; //The total number of levels of the tree

        /// <summary>
        /// Default Tree Constructor. Creates just a root node with no children.
        /// </summary>
        public Tree()
        {
            root = new Node(1);
        }

        /// <summary>
        /// Leveled Tree Constructor. Creates a tree with a specified number of levels.
        /// </summary>
        /// <param name="lev">Levels of the tree to create</param>
        public Tree(int lev)
        {
            //MakeTree(lev)
        }

        /// <summary>
        /// Creates a tree with a specified number of levels.
        /// </summary>
        /// <param name="lev">Levels of the tree to create</param>
        public void MakeTree(int lev)
        {
            //MakeTree implementation
        }

        /// <summary>
        /// Prints the tree's nodes to the console.
        /// </summary>
        public void Print()
        {
            //Print implementation
        }

        //Properties of the tree class
        public Node Root
        {
            get
            {
                return root;
            }
        }
    }
}
