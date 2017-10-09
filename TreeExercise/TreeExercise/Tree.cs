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
            levels = 1;
            MakeTree();
        }

        /// <summary>
        /// Leveled Tree Constructor. Creates a tree with a specified number of levels.
        /// </summary>
        /// <param name="lev">Levels of the tree to create</param>
        public Tree(int lev)
        {
            levels = lev;
            MakeTree();
        }

        /// <summary>
        /// Creates a tree from this class's number of levels.
        /// </summary>
        private void MakeTree()
        {
            root = new Node(1);

            //If the level goes beyond just the root
            if(levels > 1)
            {
                //Create children from root
                root.Left = new Node(root, root.Data);
                root.Right = new Node(root, root.Data);

                //Start recursive creation functions from these two children
                MakeLevel(2, root.Left);
                MakeLevel(2, root.Right); 
            }
        }

        /// <summary>
        /// Recursive function that makes a new individual level of the tree starting from currN. Stops once the number of levels is reached.
        /// </summary>
        /// <param name="currLevel">The level of the tree being made.</param>
        /// <param name="currNode">The node being initialized with new children on this level.</param>
        private void MakeLevel(int currLevel, Node currN)
        {
            //Should the recursion end? (Has the current level hit the desired number of levels?)
            if(currLevel < levels)
            {
                Node grandparent = currN.Parent.Parent;

                //Check if there is a left neighbor to this node's parent
                //First checks if there is a grandparent and then checks if that grandparent's left is actually different from this Node's parent.
                if (grandparent != null && grandparent.Left != currN.Parent)
                {
                    //Parent has a left neighbor...
                    currN.Left = new Node(currN, currN.Parent.Data + grandparent.Left.Data);
                }
                else
                {
                    currN.Left = new Node(currN, currN.Parent.Data);
                }

                //Check if there is a right neighbor to this node's parent
                if (grandparent != null && grandparent.Right != currN.Parent)
                {
                    //Parent has a right neighbor...
                    currN.Right = new Node(currN, currN.Parent.Data + grandparent.Right.Data);
                }
                else
                {
                    currN.Right = new Node(currN, currN.Parent.Data);
                }

                //Go another level deeper on the left and right
                MakeLevel(currLevel + 1, currN.Left);
                MakeLevel(currLevel + 1, currN.Right);
            }
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
