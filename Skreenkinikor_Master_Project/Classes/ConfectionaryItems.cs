using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skreenkinikor_Master_Project.Classes
{
    

    public class Node
    {
        public string Item;
        public int Amount;
        public Node Next;

    }

    public class LinkedList
    {
        private Node Head;

        // method to add a new confectionary Item and it's amount to the linkedlist
        public void AddItem(String Item, int Amount)
        {
            Node newNode = new Node();
            newNode.Item = Item;
            newNode.Amount = Amount;   
            newNode.Next = Head;
            Head = newNode;
        }

        // if the user made an error with the amount of an item they want to buy, they can subtract the amount
        public void SubtractAmount(string Item, int Amount)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Item == Item)
                {
                    current.Amount -= Amount;
                }
                current = current.Next;
            }
        }

        // allows the user to remove an item from the linked list, if they dont want to purchase said item
        public void RemoveItem(string Item)
        {
            if (Head == null)
            {
                return;
            }

            if (Head.Item == Item)
            {
                Head = Head.Next;
                return;
            }
            Node current = Head;

            while (current.Next != null)
            {
                if (current.Next.Item == Item)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }
    }
}
