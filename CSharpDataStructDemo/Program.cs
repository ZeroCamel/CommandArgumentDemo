using System;
using CSharpDataStructDemo.link;
using CSharpDataStructDemo.DLink;



namespace CSharpDataStructDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //单链表
            LinkList<string> link = new LinkList<string>();
            link.Append("123");
            link.Append("abc");
            link.Append("jgh");
            link.Insert("sde", 2);

            int length = link.getLength();
            int k = link.Locate("567");
            string m = link.GetElem(3);

            Console.WriteLine("567的位置为" + k);
            Console.WriteLine("位置为3的值为" + m);
            Console.WriteLine("链表的长度为" + length);

            Node<string> n = link.Head;
            while (n!=null)
            {
                Console.WriteLine(n.Data);
                n = n.Next;
            }
            Console.WriteLine("-----------");
            DLinkList<string> DL = new DLinkList<string>();
            DL.Append("abc");
            DL.Append("cde");
            DL.Insert("efg",2);

            DNode<string> p = DL.DLinkHead;
            while(p!=null)
            {
                Console.WriteLine(p.Data);
                p = p.Next;
            }
            
            Console.Read();
        }
    }
}
