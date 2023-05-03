using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 链表
{
    class Node
    {
        public int value;
        public Node next =null;    // 指向下一个节点
        public Node(int v)
        {
            value = v;
        }
    }
    class Program
    {
        static void AddNode(Node cur ,int n)
        {
            Node newNode = new Node(n);
            //Node temp = cur.next;   // 暂时保存下一个节点
            newNode.next = cur.next;
            cur.next = newNode;
            return;
        }

        static void RemoveNextNode(Node cur)
        {
            cur.next = cur.next.next;     // 跳过下一个节点，等价于删除
        }

        static void PrintLink(Node head)
        {
            Node temp = head; 
            while(temp!=null)
            {
                Console.WriteLine(temp.value);
                temp = temp.next;
            }
            Console.WriteLine("--------------------");
        }
        static void Main(string[] args)
        {
            Node head = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            head.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;

            // 链表创建完毕
            PrintLink(head);


            // 2.在第3个节点之后，插入一个新节点
            AddNode(head.next.next,6);
            PrintLink(head);

            // 3.删除第2个节点
            RemoveNextNode(head);
            PrintLink(head);

            //  4.★ 思考题：遍历这个链表，依次打印出所有节点的value

            LinkedList<int> link = new LinkedList<int>();   // 长度为0
            link.AddLast(11);
            link.AddLast(12);
            link.AddLast(13);
            link.AddLast(14);
            link.AddLast(15);

            //link.AddAfter(link.First.Next.Next, 16);
            // 同理，在14之前插入也一样
            link.AddBefore(link.Last.Previous, 16);

            LinkedListNode<int> node = link.First.Next;
            link.Remove(node);

            Console.ReadKey();
        }
    }
}
