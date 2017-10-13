# WGMTreeExercise
NeuroScouting Tree Exercise for interview. Written in C#.

##Compiling and Running the Code
A compiled application is at the top level of the project folder if you want to simply run the program.
If you'd like to look at the code you can just open any of the scripts or open the Visual Studio solution entirely.

##How it Works
The tree consists of nodes that belong to their own class in order to hold it's numerical data as well as variables to determine if it is on an edge or
if it is the left or right child of another node. The tree itself is array based and contains a method to construct a tree through the creation of several nodes.
The user selects how many levels deep the tree should be upon creation.  
The tree is created with the rules that all left children have a value of its parent value plus the value of the parent's left neighbor and  
all right children have a value of its parent value plus the value of the parent's right neighbor. If the parent node does not have the proper neighbor
then the child node simply matches the value of the parent.

##How the Code is Organized
* Node Class
  * Member variables
    * data
	* isEdge (integer where value is 0 for not an edge, -1 for left-most edge, and 1 for right most edge)
	* isLeftChild (boolean that is true for a left child and false for a right child. Also false for the root node.)
  * A few different constructors for different initial data combinations.
  * Several properties to access or change member variables..
* Tree Class
  * Member variables
    * root (Node typed root of the tree)
	* levels (integer for the number of levels the tree is set to)
	* allNodes (array of all Nodes in the tree. Indexed from left to right, top to bottom)
  * Constructor accepts an integer parameter for the number of levels, initializes allNodes, then calls MakeTree()
  * MakeTree()
    * Makes the root at index 1. (I'd much rather prefer to start at 0, but this actually makes much of the math easier)
    * Runs through the rest of allNodes indices and creates appropriate nodes.
	* Uses the fact that parent's neighbors can be accessed with: parent's index + 1 or parent's index - 1.
  * Print()
    * Prints the tree to the console.
    * Time Restraints
	  * Due to my shortened amount of time printing still contains a spacing bug where the root's data is placed oddly in the console.
	  * For now the tree can be decently viewed up to level 5 or 6.
	  * Because of this I also have printed out all the nodes by index one by one if something needs to be checked specifically.
	* Calculates how many spaces in the console are necessary for the number of nodes at the bottom level.
	* Runs through all nodes while adjusting the number of gaps and spaces needed as the level of the tree increases on the way down.
  * Contains a helper method to quickly insert spaces into the console.

##Interesting Optimizations
I originally attempted the tree with a typical relationship base that had Nodes holding references to its children and its parent.
This quickly broke down as the amount of traversal would have been ridiculous in many cases when finding parent's neighbors.
I switched to an array based tree so that parent's indices are simply (currentIndex/2) and parent's neighbors are (currentIndex + or - 1).
This both greatly improved performance, but also made the code much easier to understand.  
By providing an isEdge variable to the nodes it made printing new lines much more simple as well as making the code easy to read.


