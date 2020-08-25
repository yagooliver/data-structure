using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryTree.Client
{
    public class Bst<T> where T : IComparable<T>
    {
        private TreeNode<T> _root;
        Queue
        public TreeNode<T> Get(T value) => _root?.Get(value);

        public T Min()
        {
            if(_root == null)
                throw new InvalidOperationException("Empty tree");
            
            return _root.Min();
        }

        public T Max()
        {
            if(_root == null)
                throw new InvalidOperationException("Empty tree");
            
            return _root.Max();
        }

        public void Insert(T value)
        {
            if(_root == null)
                _root = new TreeNode<T>(value);
            else
                _root.Insert(value);
        }

        public IEnumerable<T> TraverseInOrder()
        {
            if(_root != null)
                return _root.TraverseInOrder();
            
            return Enumerable.Empty<T>();
        }

        public void Remove(T value)
        {
            _root = Remove(_root, value);
        }

        public TreeNode<T> Remove(TreeNode<T> subTreeRoot, T value)
        {
            if(subTreeRoot == null)
                return null;
            
            int compareTo = value.CompareTo(subTreeRoot.Value);
            if(compareTo < 0)
            {
                subTreeRoot.Left = Remove(subTreeRoot.Left, value);
            }
            else if(compareTo > 0)
            {
                subTreeRoot.Right = Remove(subTreeRoot.Right, value);
            }
            else
            {
                if(subTreeRoot.Left == null)
                {
                    return subTreeRoot.Right;
                }
                if(subTreeRoot.Right == null)
                {
                    return subTreeRoot.Left;
                }

                subTreeRoot.Value = subTreeRoot.Right.Min();
                subTreeRoot.Right = Remove(subTreeRoot.Right, subTreeRoot.Value);
            }

            return subTreeRoot;
        }
    }
}