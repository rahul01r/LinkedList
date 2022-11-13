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
                Console.WriteLine("Select Programs\n1.Create LinkedList\n2.Add the Elemente in Reverse Order\n3.Appending the Elemente in LinkedList\n4.Insert The Value At Particular Posation\n5.Delete the first element in linked list");
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

                }
            }
        }
    }
}