using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDataStructDemo.DLink
{
    public class DLinkList<T> : IDlistDs<T>
    {
        private DNode<T> dLinkHead;

        public DNode<T> DLinkHead
        {
            get
            {
                return dLinkHead;
            }

            set
            {
                dLinkHead = value;
            }
        }

        public DLinkList()
        {
            DLinkHead = null;
        }
        public void Append(T item)
        {
            if (DLinkHead == null)
            {
                DLinkHead = new DNode<T>(item);
            }
            DNode<T> dn = new DNode<T>(item);
            DLinkHead.Next = dn;
            dn.Pre = DLinkHead;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public T Delete(int i)
        {
            throw new NotImplementedException();
        }

        public T GetElem(int i)
        {
            throw new NotImplementedException();
        }

        public int getLength()
        {
            throw new NotImplementedException();
        }

        public void Insert(T item, int i)
        {
            if (dLinkHead == null || i < 1)
            {
                Console.WriteLine("双链表为空或者参数有误");
            }
            DNode<T> dn = new DNode<T>();
            dn.Data = item;
            DNode<T> d1 = dLinkHead;
            DNode<T> d2 = null;
            int j = 1;
            if (i == 1)
            {
                d1.Next = dn;
                dn.Pre = d1;
            }
            else
            {
                while (d1.Next != null && j < i)
                {
                    d2 = d1;
                    d1 = d1.Next;
                    j++;
                }
                if (j == i)
                {
                    dn.Pre = d2.Next;
                    d2.Next = dn;

                    d1.Pre = dn;
                    dn.Next = d1;
                }
                else
                {
                    Console.WriteLine("插入位置不合法");
                }
            }

        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public int Locate(T value)
        {
            throw new NotImplementedException();
        }
    }
}
