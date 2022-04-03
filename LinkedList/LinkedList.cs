namespace LinkedList.LinkedList
{
    //this class will have the logic
    //to connect the node objects to create
    //link list structure
    public class LinkedList
    {
        private Node start;

        public LinkedList()
        {
            start = null;
        }

        public void DisplayList()
        {
            Node p = start;

            if(start == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            while (p != null)
            {
                Console.WriteLine(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }

        public bool SearchList(int x)
        {
            int position = 1;
            
            Node p = start;
            while(p!= null)
            {
                if (p.info == x)
                    break;
                position++;
                p = p.link;
            }

            if (p == null)
            {
                Console.WriteLine(x + "not found in list");
                return false;
            }
            else
            {
                Console.WriteLine(x + "is at position" + position);
                return true;
            }
        }

        public void CountNodes()
        {
            Node p = start;
            int count = 1;

            while( p != null)
            {
                count++;
                p = p.link;
            }

            Console.WriteLine("Count of list" + count);
        }

        //Finding the last Node in the list
        public void LastNode()
        {
            Node p = start;
            while(p.link !=null)
            {
                p = p.link;
            }
        }

        //Finding the Second last Node in the list
        public void SecondLastNode()
        {
            Node p = start;
            while(p.link.link !=null)
            {
                p = p.link;
            }
        }

        //Finding Reference to a node with particular info
        public Node referenceToNode(int x)
        {
            Node p = start;
            while(p !=null)
            {
                if (p.info == x)
                    break;
                p = p.link;
            }
            return p;
        }

        //Finding reference to predecessor of a node with particular info
        public Node predecessorOfNode(int x)
        {
            Node p = start;

            while(p.link !=null)
            {
                if (p.link.info == x)
                    break;
                p =p.link;
            }
            return p;
        }

        //Finding reference to a node at a particular position

        public Node referenceToNodeAtParticularPosition(int position)
        {
            Node p = start;
            for(int i  = 1; i< position && p!=null; i++)
            {
                p =p.link;
            }

            return p;
        }

        //Insertion in a Single Linked List at the Beginning

        public void InsertAtBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;
        }

        //Insertion in a Single Linked List at the End
        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data); //create a node

            if(start == null) // if the list is empty, insert at the start of list
            {
                start = temp;
                return;
            }

            p = start;

            while(p.link!=null)
                p= p.link;

            p.link = temp;// insert temp at the end of list
        }

        //Insertion after a given node

        public void InsertAfterANode(int x, int data)
        {
            Node p;
            p = start;

            Node temp = new Node(data);

            while(p != null) //p!=null to insert a node after a given node
            {
                if (p.info == x)
                    break;
                p = p.link;
            }

            if (p == null)
                Console.WriteLine("Node with data x is not present in the list");
            else
            {
                temp.link = p.link;
                p.link = temp;
            }
            
        }

        //Insertion before a given node

        public void InsertBeforeANode(int x, int data)
        {
            Node temp;

            if (start == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }

            /*x is present in the first position*/
            if(x == start.info)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }
            Node p = start;
            //Find the predecessor and insert the node
            while (p.link != null) //p.link! = null to insert a node before a given node
            {
                if (p.info == x)
                    break;
                p = p.link;
            }

            if (p.link == null)
                Console.WriteLine("Node with data x is not present in the list");
            else
            {

                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }

        }

        //Insertion of new node at the kth postion in the list

        public void InsertAtParticularPosition(int data, int position)
        {
            Node temp;
            int i;

            if (position == 1) // To insert at first position
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;
            for ( i = 1 ; i< position -1 && p!=null ;i++) //Find reference to k-1 node
            {
                p= p.link;
            }

            if (p == null)
                Console.WriteLine("You can insert only upto " + i + "th position");
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }

        }

        public void CreateList()
        {
            int i, n, data;

            Console.WriteLine("Enter the no of nodes");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;
            for(i=1;i<=n;i++)
            {
                Console.WriteLine("Enter the element");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }

        public void DeleteFirstNode() //Delete First Node
        {
            if (start == null)
                return;
            else
                start = start.link;
        }
        public void DeleteLastNode()
        {
            if (start == null) //If list is empty
                return;

            if(start.link == null) //Only node in the list
            {
                start = null;
                return;
            }

            Node p = start;
            //1 Find last node
            //2 p.link.link -> second last node.
            //3 delete it and assign p.link = null
            while(p.link.link != null)
                p = p.link;
            p.link = null;
           
        }

        public void DeleteNode(int x)
        {
            /*List is empty*/
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            /*Deletion of first node*/
            if (start.info == x)
            {
                start = start.link;
                return;
            }

            /*Deletion in between or at the end of the list*/
            Node p = start;
            while(p.link !=null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }

            if (p.link == null)
                Console.WriteLine("Element" + x + "not found in the list");
            else
                p.link = p.link.link;
        }

        public void ReverseList()
        {
            Node prev, p, next;

            prev = null; 
            p = start;

            while(p != null)
            {
                next = p.link;
                p.link = prev;
                prev = p;
                p = next;
            }

            start = prev;

        }

        public void BubbleSortLinkedListExchangeData()
        {
            Node p, q, end;

            for(end = null; end != start.link; end = p ) // Pass of Bubble Sort , loop stops when end refers to second node
            {
                for( p = start; p.link !=end ; p = p.link) // Every pass of bubble sort
                {
                    q = p.link;
                    if(p.info > q.info)
                    {
                        int temp = p.info;
                        p.info = q.info;
                        q.info = temp;
                    }
                }
            }
        }

        public void BubbleSortExchangeLink()
        {
            Node end, p, q, r, temp;

            for(end =null; end != start.link; end = p ) // Pass of Bubble Sort , loop stops when end refers to second node
            {
                for (r = p = start; p.link != end; r = p, p= p.link) // Every pass of bubble sort
                {
                    q =p.link;

                    if(p.info > q.info)
                    {
                        p.link = q.link;
                        q.link = p;

                        if (p != start)
                            r.link = q;
                        else
                            start = q;

                        temp = p;
                        p = q;
                        q = temp;
                    }

                }
            }
        }
    }
}
