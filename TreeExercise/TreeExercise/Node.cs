using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    /*
    William Montgomery Node
    Contains an integer value that is incorporated into a Tree.
    */
    class Node
    {
        private int data; //The node's data
        private int isEdge; //0 for not an edge, -1 for left-most edge, and 1 for right-most edge
        private bool isLeftChild; //True for left child, False for right child

        /// <summary>
        /// Default Node constructor. Data set to 0.
        /// </summary>
        public Node()
        {
            data = 0;
        }

        /// <summary>
        /// Construct Node with initial data.
        /// </summary>
        /// <param name="d">Node Data</param>
        public Node(int d)
        {
            data = d;
        }

        /// <summary>
        /// Construct Node with initial data.
        /// </summary>
        /// <param name="d">Node Data</param>
        public Node(int d, int edge, bool child)
        {
            data = d;
            IsEdge = edge;
            IsLeftChild = child;
        }

        //Properties of Node class
        public int Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public int IsEdge
        {
            get
            {
                return isEdge;
            }

            set
            {
                isEdge = value;
            }
        }

        public bool IsLeftChild
        {
            get
            {
                return isLeftChild;
            }

            set
            {
                isLeftChild = value;
            }
        }
    }
}
