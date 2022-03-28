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

                }
            }
        }
    }
}
