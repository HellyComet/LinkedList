using LinkedList;

namespace LinkedList.LinkedList
{
    public class Program
    {
        static void Main(string[]args)
        {
            int choice, data, k, x;

            LinkedList list = new LinkedList();

            list.CreateList();

            while(true)
            {
                Console.WriteLine("1.Display list");
                Console.WriteLine("2.Count the number of nodes");
                Console.WriteLine("3.Search for an element");
                Console.WriteLine("4.Insert in empty list/Insert in beginning of the list");
                Console.WriteLine("5.Insert a node at the end of the list");
                Console.WriteLine("6.Insert a node after a specified node");
                Console.WriteLine("7.Insert a node before a specified node");
                Console.WriteLine("8.Insert a node at a given position");
                Console.WriteLine("9.Delete First Node");
                Console.WriteLine("10.Delete Last Node");
                Console.WriteLine("11.Delete a particular Node");
                Console.WriteLine("12.Reverse a list");
                Console.WriteLine("13.Bubble Sort Exchanging Data");
                Console.WriteLine("14.Bubble Sort Exchanging Links");
                Console.WriteLine("19.Quit");

                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 19)
                    break;

                switch(choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        list.CountNodes();
                        break;
                    case 3:
                        Console.WriteLine("Enter the element to be searched");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.SearchList(data);
                        break;
                    case 4:
                        Console.WriteLine("Enter the element at the beginning of the list");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtBeginning(data);
                        break;
                    case 5:
                        Console.WriteLine("Enter the element to insert at the end of list");
                        data=Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;
                    case 6:
                        Console.Write("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element after which to insert : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfterANode(data, x);
                        break;
                    case 7:
                        Console.Write("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element before which to insert : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBeforeANode(data, x);
                        break;
                    case 8:
                        Console.Write("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the position at which to insert");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtParticularPosition(data, x);
                        break;
                    case 9:
                        Console.Write("Delete First Node");
                        list.DeleteFirstNode();
                        break;
                    case 10:
                        Console.Write("Delete Last Node");
                        list.DeleteLastNode();
                        break;
                    case 11:
                        Console.Write("Enter node to be deleted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;
                    case 12:
                        Console.Write("Reverse the list");
                        list.ReverseList();
                        break;
                    case 13:
                        Console.Write("Bubble Sort With Exchanging Data");
                        list.BubbleSortLinkedListExchangeData();
                        break;
                    case 14:
                        Console.Write("Bubble Sort With Exchanging Links");
                        list.BubbleSortExchangeLink();
                        break;
                    default:
                        Console.WriteLine("Wrong choice entered");
                        break;

                }
            }
        }
    }
}
