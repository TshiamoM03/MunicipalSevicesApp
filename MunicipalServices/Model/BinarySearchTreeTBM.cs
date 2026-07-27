using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MunicipalServices.Model
{
    // BST organises and retrieves Issues information
    public class BinarySearchTreeTBM
    {
        public IssueNode Root;

        public BinarySearchTreeTBM()
        {
            Root = null;
        }

        //insert new key (issue) - ensure new issues are stored in order of their issue ID
        public IssueNode Insert(IssueNode node, Issue key)
        {
            if(node == null)
            {
                return new IssueNode(key);
            }

            if(key.IssueId < node.Key.IssueId)
            {
                node.Left = Insert(node.Left, key);
            }
            else if(key.IssueId > node.Key.IssueId)
            {
                node.Right = Insert(node.Right, key);
            }
            return node;
        }
        
        public void Insert(Issue key)
        {
            Root = Insert(Root, key);
        }

        // quickly find service request by its ID -> O(log n) complexity
        public Issue Search(int issueId)
        {
            return Search(Root, issueId);
        }

        public Issue Search(IssueNode node, int issueId)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Key.IssueId == issueId)
            {
                return node.Key;
            }

            if (issueId < node.Key.IssueId)
            {
                return Search(node.Left, issueId);
            }
            else
            {
                return Search(node.Right, issueId);
            }
        }

        public IssueNode Delete(IssueNode root, int issueId)
        {
            if(root == null)
            {
                return root;
            }

            if(issueId < root.Key.IssueId)
            {
                root.Left = Delete(root.Left, issueId);
            }
            else if(issueId > root.Key.IssueId)
            {
                root.Right = Delete(root.Right, issueId);
            }
            else
            {
                // node with one child or no child
                if(root.Left == null)
                {
                    return root.Right;
                }
                else if(root.Right == null)
                {
                    return root.Left;
                }

                //node with 2 children
                root.Key = FindMin(root.Right).Key;
                //root.Right = Delete(root.Right, root.Key.IssueId);
            }
            return root;
        }
    
        public IssueNode FindMin(IssueNode node)
        {
            while(node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        //traversal (sorted in order of request id ) 
        public List<Issue> InOrderTraversal(IssueNode node)
        {
            List<Issue> list = new List<Issue>();
            if(node != null)
            {
                list.AddRange(InOrderTraversal(node.Left));
                list.Add(node.Key);
                list.AddRange(InOrderTraversal(node.Right));
            }
            return list;
        }
        

        public int CountNodes(IssueNode node)
        {
            if(node == null)
            {
                return 0;
            }
            return 1 + CountNodes(node.Left) + CountNodes(node.Right);
        }

        public int Count()
        {
            return CountNodes(Root);
        }
    }//end  of bst 

    /*--------------------
     * Node class for Issues
     --------------------*/
    public class IssueNode
    {
        public Issue Key;
        public IssueNode Left;
        public IssueNode Right;

        public IssueNode(Issue item) 
        {
            Key = item;
            Left = null;
            Right = null;
        }
    }
}
/* The implimentation is derived from the following sources
 * https://medium.com/better-programming/introduction-to-binary-search-trees-dde166368210
 * https://medium.com/@konduruharish/binary-search-tree-in-typescript-and-c-25fa5107cc5d
 */