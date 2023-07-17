namespace BinarySearchTree
{
    // C# function to search a given key in a given BST

    using System;

    public class Node
    {
        public int key;
        public Node left, right;
    }

    public class BinaryTree
    {
        // A utility function to create a new BST node
        public Node NewNode(int item)
        {
            Node temp = new Node();
            temp.key = item;
            temp.left = temp.right = null;
            return temp;
        }

        // A utility function to insert
        // a new node with given key in BST
        public Node Insert(Node node, int key)
        {
            // If the tree is empty, return a new node
            if (node == null)
                return NewNode(key);

            // Otherwise, recur down the tree
            if (key < node.key)
                node.left = Insert(node.left, key);
            else if (key > node.key)
                node.right = Insert(node.right, key);

            // Return the (unchanged) node pointer
            return node;
        }

        // Utility function to search a key in a BST
        public Node Search(Node root, int key)
        {
            // Base Cases: root is null or key is present at root
            if (root == null || root.key == key)
                return root;

            // Key is greater than root's key
            if (root.key < key)
                return Search(root.right, key);

            // Key is smaller than root's key
            return Search(root.left, key);
        }

        // Driver Code
        public static void Main()
        {
            Node root = null;
            BinaryTree bt = new BinaryTree();
            root = bt.Insert(root, 50);
            bt.Insert(root, 30);
            bt.Insert(root, 20);
            bt.Insert(root, 40);
            bt.Insert(root, 70);
            bt.Insert(root, 60);
            bt.Insert(root, 80);

            // Key to be found
            int key = 6;

            // Searching in a BST
            if (bt.Search(root, key) == null)
                Console.WriteLine(key + " not found");
            else
                Console.WriteLine(key + " found");

            key = 60;

            // Searching in a BST
            if (bt.Search(root, key) == null)
                Console.WriteLine(key + " not found");
            else
                Console.WriteLine(key + " found");
        }
    }
}
