using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDataStructDemo.link
{
    public class LinkList<T> : IListDs<T>
    {
        //单链表的头引用
        private Node<T> head;

        public Node<T> Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }

        //构造函数
        public LinkList()
        {
            head = null;
        }

        public void Append(T item)
        {
            //为新元素构造节点
            Node<T> q = new Node<T>(item);
            //哨兵
            Node<T> p = null;
            if (head == null)
            {
                head = q;
                return;
            }
            //哨兵赋值并寻找插入点
            p = head;
            while (p.Next != null)
            {
                p = p.Next;
            }
            //找到后将新节点的引用赋值链表的最后节点
            p.Next = q;
        }

        //清空链表
        public void Clear()
        {
            head = null;
        }

        //删除单链表
        public T Delete(int i)
        {
            if (IsEmpty() || i < 1)
            {
                Console.WriteLine("链表为空或者参数错误！");
                return default(T);
            }
            Node<T> q = new Node<T>();
            if (i == 1)
            {
                q = head;
                head = head.Next;
                return q.Data;
            }
            Node<T> p = head;
            int j = 1;
            while (p.Next != null && j < i)
            {
                q = p;
                p = p.Next;
                j++;
            }
            if (j == i)
            {
                q.Next = p.Next;
                return p.Data;
            }
            else
            {
                Console.WriteLine("插入位置不正确");
                return default(T);
            }

        }

        //获取某个链表元素
        public T GetElem(int i)
        {
            if (IsEmpty())
            {
                Console.WriteLine("链表是空链表");
                return default(T);
            }
            Node<T> p = head;
            int j = 1;
            while (p.Next != null && j < i)
            {
                p = p.Next;
                j++;
            }
            if (j == i)
            {
                return p.Data;
            }
            else
            {
                Console.WriteLine("位置不正确");
            }
            return default(T);
        }

        //获取链表长度
        public int getLength()
        {
            Node<T> p = head;
            int len = 0;
            if (p != null)
            {
                p = p.Next;
                len++;
            }
            return len;
        }

        //指定位置前插入指定元素
        public void Insert(T item, int i)
        {
            if (IsEmpty() && i < 1)
            {
                Console.WriteLine("链表为空或者位置错误");
                return;
            }

            //构建新节点
            Node<T> q = new Node<T>(item);
            if (i == 1)
            {
                q.Next = head;
                head = q;
                return;
            }

            //新建哨兵
            Node<T> p = head;
            Node<T> r = new Node<T>();
            int j = 1;
            while (p.Next != null && j < i)
            {
                r = p;
                p = p.Next;
                j++;
            }
            if (j == i)
            {
                r.Next = q;
                q.Next = p;
            }
        }
        //在指定位置后插入指定元素
        public void InsertPost(T item, int i)
        {
            //修改插入位置变量I，将问题转化为在指定位置前插入
            return;
        }

        //判断链表是否为空
        public bool IsEmpty()
        {
            return head == null;
        }

        //定位链表元素 返回和元素第一个相等的值
        public int Locate(T value)
        {
            if (IsEmpty() || value == null)
            {
                Console.WriteLine("链表为空或者定位元素值有误");
            }
            Node<T> p = head;
            int i=1;
            while (p.Next != null&&(!p.Data.Equals(value)))
            {
                //Operator == cannot be applied to T
                i++;
                p = p.Next;
            }
            if (p==null)
            {
                Console.WriteLine("不存在这样的节点");
                return -1;
            }
            else
            {
                return i;
            }
        }
    }
}
