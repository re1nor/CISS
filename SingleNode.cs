using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSystem
{
    class SingleNode<TreeNode>
    {
        public int Key { get; set; }
        public TreeNode Value { get; set; }
        public SingleNode<TreeNode> Next { get; set; }

        public SingleNode()
        {
            Key = 0;
            Value = default;
            Next = null;
        }

        public SingleNode(int key, TreeNode value, SingleNode<TreeNode> next)
        {
            Key = key;
            Value = value;
            Next = next;
        }

        public SingleNode(int key, TreeNode value)
        {
            Key = key;
            Value = value;
            Next = null;
        }

        public override string ToString()
        {
            return string.Format("id:{0} Значение = {1}", Key, Value);
        }



    }
}
