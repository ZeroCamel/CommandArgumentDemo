using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDataStructDemo.DLink
{
    //双链表结点定义
    public class DNode<T>
    {
        private T data;
        private DNode<T> pre;
        private DNode<T> next;

        public DNode<T> Pre
        {
            get
            {
                return pre;
            }

            set
            {
                pre = value;
            }
        }

        public DNode<T> Next
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

        public DNode()
        {
            this.Data = default(T);
            this.Pre = null;
            this.Next = null;
        }
        public DNode(T data)
        {
            this.Data = data;
        }
        public DNode(T data,DNode<T> pre,DNode<T> next)
        {
            this.Data = data;
            this.Pre = pre;
            this.Next = next;
        }
    }
}
