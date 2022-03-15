using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSystem
{
        public class TreeNode
        {
        public string Name;
        public List<TreeNode> listOF = new List<TreeNode>();
            

            
            public TreeNode(string nameOfNode)
            {
                Name = nameOfNode;
                
            }
            public virtual void Print()
            {
                Console.WriteLine();
                Console.WriteLine($"Name: {Name}");
                foreach (TreeNode node in this.listOF)
                {
                node.Print();
                }
            }
        
    }   

}
