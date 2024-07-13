using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class TreeNode
    {
        public object Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }


    public class BinarySearchTree
    {
        private TreeNode Root { get; set; }
        private int Count { get; set; }

        public BinarySearchTree()
        {
            Root = null;
            Count = 0;
        }

        public void Add(int value)
        {
            TreeNode newNode = new TreeNode(value);
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                InsertRecursively(Root, newNode);
            }
            Count++;
        }

        private void InsertRecursively(TreeNode current, TreeNode newNode)
        {
            if ((int)newNode.Value < (int)current.Value)
            {
                if (current.Left == null)
                {
                    current.Left = newNode;
                }
                else
                {
                    InsertRecursively(current.Left, newNode);
                }
            }
            else
            {
                if (current.Right == null)
                {
                    current.Right = newNode;
                }
                else
                {
                    InsertRecursively(current.Right, newNode);
                }
            }
        }

        public bool Contains(int value)
        {
            return SearchRecursively(Root, value);
        }

        private bool SearchRecursively(TreeNode current, int value)
        {
            if (current == null)
            {
                return false;
            }
            if ((int)current.Value == value)
            {
                return true;
            }
            else if (value < (int)current.Value)
            {
                return SearchRecursively(current.Left, value);
            }
            else
            {
                return SearchRecursively(current.Right, value);
            }
        }

        public void Clear()
        {
            Root = null;
            Count = 0;
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];
            int index = 0;
            InOrderTraverse(Root, ref array, ref index);
            return array;
        }

        private void InOrderTraverse(TreeNode current, ref int[] array, ref int index)
        {
            if (current != null)
            {
                InOrderTraverse(current.Left, ref array, ref index);
                array[index] = (int)current.Value;
                index++;
                InOrderTraverse(current.Right, ref array, ref index);
            }
        }
    }
}
