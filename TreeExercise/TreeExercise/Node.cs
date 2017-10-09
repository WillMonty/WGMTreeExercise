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
        private Node parent;
        private Node left;
        private Node right;
        private int data;

        /// <summary>
        /// Default Node constructor. Data set to 0.
        /// </summary>
        public Node()
        {
            data = 0;
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="p">Node Parent</param>
        /// <param name="l">Left Child of the Node</param>
        /// <param name="r">Right Child of the Node</param>
        /// <param name="d">Node Data</param>
        public Node(Node p, Node l, Node r, int d)
        {
            parent = p;
            left = l;
            right = r;
            data = d;
        }

        /// <summary>
        /// Construct Node with initial data.
        /// </summary>
        /// <param name="d">Node Data</param>
        public Node(int d)
        {
            data = d;
        }

        //Properties of Node class
        public Node Parent
        {
            get
            {
                return parent;
            }

            set
            {
                parent = value;
            }
        }

        public Node Left
        {
            get
            {
                return left;
            }

            set
            {
                left = value;
            }
        }

        public Node Right
        {
            get
            {
                return right;
            }

            set
            {
                right = value;
            }
        }

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
    }
}
