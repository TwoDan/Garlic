using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garlic.Utility
{
    /// <summary>
    /// 这是干嘛的，我也不知道！
    /// </summary>
    public class Tree
    {
        public List<TreeNode> TreeNodes { get; set; }

        public string SelectPath { get; set; }//选中路径

        bool _ShowLine = true;
        public bool ShowLine
        {
            get { return _ShowLine; }
            set { _ShowLine = value; }
        }

        ShowCheckBoxs _ShowCheckBox = ShowCheckBoxs.None;
        public ShowCheckBoxs ShowCheckBox
        {
            get { return _ShowCheckBox; }
            set { _ShowCheckBox = value; }
        }

        int _ExpentDepth = 0;
        public int ExpentDepth
        {
            get { return _ExpentDepth; }
            set { _ExpentDepth = value; }
        }
    }

    public class TreeNode
    {
        public string TreeNodeID { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
        NodeDispType _NodeDispType = NodeDispType.Span;//0:不是超链接 1:超链接
        public NodeDispType NodeDispType
        {
            get { return _NodeDispType; }
            set { _NodeDispType = value; }
        }
        public bool? ShowCheckBox { get; set; }
        public bool Checked { get; set; }
        public string Tag { get; set; }
        //public bool?    Expanded { get; set; }
        public string htmlAttr { get; set; }
        public string ParentTreeNodeID { get; set; }

    }

    public enum ShowCheckBoxs
    {
        None,
        Root,
        Parent,
        Leaf,
        All
    }

    public enum NodeDispType
    {
        Alink,
        Button,
        Span
    }
}
