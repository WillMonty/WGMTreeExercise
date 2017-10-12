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
        private Node[] allNodes; //Every node in the tree

        /// <summary>
        /// Default Tree Constructor. Creates just a root node with no children.
        /// </summary>
        public Tree()
        {
            levels = 1;
        }

        /// <summary>
        /// Leveled Tree Constructor. Creates a tree with a specified number of levels.
        /// </summary>
        /// <param name="lev">Levels of the tree to create</param>
        public Tree(int lev)
        {
            levels = lev;
            allNodes = new Node[(int)Math.Pow(2, levels)];
            MakeTree();
        }

        /// <summary>
        /// Creates a tree from this class's number of levels.
        /// </summary>
        private void MakeTree()
        {
            root = new Node(1);
            allNodes[1] = root; //Indexed starting at 1 for index math to be cleaner

            //If the level goes beyond just the root
            if(levels > 1)
            {
                int currLevel = 2; //What level is the tree currently building on?
                for (int i = 2; i < allNodes.Length; i++)
                {
                    Node currNode = new Node();
                    int parentIndex = i / 2; //Parent of this node is half the node's index. (Integer division)

                    //Is this node a left or right child? Left children have an even index.
                    currNode.IsLeftChild = (i % 2 == 0) ? true : false;

                    //Is this node on a far edge?
                    if (i == Math.Pow(2, currLevel - 1))  //Left most edge
                    {
                        currNode.IsEdge = -1;
                    }
                    else if(i == Math.Pow(2, currLevel) - 1) //Right most edge
                    {
                        currNode.IsEdge = 1;
                        currLevel++; //New level will begin after this node
                    }


                    //Get Node's data based on these properties
                    if(currNode.IsLeftChild) //Left Children
                    {
                        if(currNode.IsEdge == -1) //Nodes on the left-most edge have parents without left neighbors
                        {
                            currNode.Data = allNodes[parentIndex].Data;
                        }
                        else
                        {
                            currNode.Data = allNodes[parentIndex].Data + allNodes[parentIndex - 1].Data;
                        }
                    }
                    else //Right Children
                    {
                        if (currNode.IsEdge == 1) //Nodes on the right-most edge have parents without right neighbors
                        {
                            currNode.Data = allNodes[parentIndex].Data;
                        }
                        else
                        {
                            currNode.Data = allNodes[parentIndex].Data + allNodes[parentIndex + 1].Data;
                        }
                    }

                    allNodes[i] = currNode; //Add completed node to the node array
                }
            }
        }

        /// <summary>
        /// Prints the tree's nodes to the console.
        /// </summary>
        public void Print()
        {
            int totalSpaces = allNodes.Length * 2; //Total spaces is based on how many nodes will be printed plus some padding. Max width of tree
            int gaps = 2; //Number of gaps at this level of the tree. Root has a gap on either side so 2 gaps to start.
            int currLevel = 1;

            //Put in root first since it is an edge case
            insertSpaces(totalSpaces / gaps);
            Console.Write(root.Data);
            Console.WriteLine();

            currLevel++;
            //gaps = (2 + (int)Math.Pow(2, currLevel));
            gaps *= 2;

            if (levels == 1) //If level doesn't go beyond root
            {
                return;
            }

            //Go through rest of nodes
            for (int i = 2; i < allNodes.Length; i++)
            {
                int spacesPerGap = totalSpaces / gaps;
                if (allNodes[i].IsEdge == -1) //If this is the left most node insert initial spaces
                {
                    insertSpaces(spacesPerGap);
                }

                Console.Write(allNodes[i].Data);
                insertSpaces(spacesPerGap);

                //If this is the right most node and not the last level, insert a new line of slashes and a new line for the next level
                if (allNodes[i].IsEdge == 1 && currLevel != levels)
                {
                    Console.WriteLine();
                    currLevel++;
                    //gaps = (2 + (int)Math.Pow(2, currLevel)); //Increase number of gaps for next level
                    gaps *= 2;
                    spacesPerGap = totalSpaces / gaps;
                }
            }
            Console.WriteLine(); //New line to end the print
        }


        /// <summary>
        /// Helper method to insert a number of spaces into the console window
        /// </summary>
        /// <param name="numSpaces"></param>
        private void insertSpaces(int numSpaces)
        {
            for(int i = 0; i < numSpaces; i++)
            {
                Console.Write(" ");
            }
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
