using System.Collections.Generic;

namespace LinkedListProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs\n1.Create LinkedList\n2.Add the Elemente in Reverse Order\n3.Appending the Elemente in LinkedList\n4.Insert The Value At Particular Posation\n5.Delete the first element in linked list\n6.Delete the last Element in Linked List\n7.Search for the element in the linked list\n8.Insert the node After Particular node\n9.Delete the middle node and Find the size of LinkdList\n10.Ascending Ordeer ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.Display();
                        break;
                    case 2:
                        list.AddInReverseOrder(70);
                        list.AddInReverseOrder(30);
                        list.AddInReverseOrder(56);
                        list.Display();
                        break;
                    case 3:
                        list.Append(56);
                        list.Append(30);
                        list.Append(70);
                        list.Display();
                        break;
                    case 4:
                        list.InsertAtParticularPosition(2, 30);
                        list.Display();
                        break;
                    case 5:
                        list.Pop();
                        list.Display();
                        break;
                    case 6:
                        list.PopLast();
                        list.Display();
                        break;
                    case 7:
                        list.Search(15);
                        list.Display();
                        break;
                    case 8:
                        list.InsertNodeAfterParticularNode(40, 30);
                        list.Display();
                        break;
                    case 9:
                        list.DeleteMiddleNode(30);
                        list.Size();
                        list.Display();
                        break;
                    case 10:
                        list.AscendingOrderSort(15);
                        list.AscendingOrderSort(18);
                        list.AscendingOrderSort(1);
                        list.AscendingOrderSort(8);
                        list.Display();
                        break;
                }
            }
        }
    }
}