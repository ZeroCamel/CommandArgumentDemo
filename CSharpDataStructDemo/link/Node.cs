using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDataStructDemo.link
{
    //单链表的基本结构
    public class Node<T>
    {
        private T data;//数据域
        private Node<T> next;//引用域

        public Node(T val,Node<T> p)
        {
            data = val;
            next = p;
        }
        public Node(T val)
        {
            data = val;
        }
        public Node(Node<T> p)
        {
            next = p;
        }
        public Node()
        {
            data = default(T);
            next = null;
        }
        public T Data
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
        public Node<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
    }
}
