using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConcept
{
    public class LibraryManagement<T>
    {
        
        public int Size { get; set; }

        public doublyLinkedNode<T> Head { get; private set; }

        public doublyLinkedNode<T> Tail { get; private set; }

        public void InsertFirst(T element)
        {
            doublyLinkedNode<T> newNode = new doublyLinkedNode<T>() { Element = element, Next = Head };
            if (Head != null)
            {
                Head.Previous = newNode;
            }
            else
            {
                
                Tail = newNode;
            }
            Head = newNode; 
            Size++; 
        }

        public T RemoveFirst()
        {
            if(Head == null)
            {
                throw new InvalidOperationException("You cannot remove an element from an empty list!");
            }
            T objectToReturn = Head.Element;

            Head = Head.Next;
            

            if(Head == null)
            {
                Head.Previous = null;
                Tail = null;
            }

            Size--;
            return objectToReturn;

        }

        public void InsertLast(T element)
        {
            doublyLinkedNode<T> newNode = new doublyLinkedNode<T>() { Element = element,Previous = Tail };
            if(Tail != null)
            {
                Tail.Next = newNode;
            }
            Tail = newNode;
            if(Head == null)
            {
                Head = newNode;
            }
            Size++;

        }

        public T RemoveLast()
        {
            if(Tail == null)
            {
                throw new InvalidOperationException("You Cannot remove an element from an empity linked list!");
            }
            T objectToReturn = Tail.Element;

            Tail = Tail.Previous;
            
            if(Tail == null)
            {
                Tail.Next = null;
                Head = null;

            }

            Size--;
            return objectToReturn;
             

        }

        public void InsertAfter(T element,doublyLinkedNode<T> currentNode)
        {
            doublyLinkedNode<T> newNode = new doublyLinkedNode<T> { Element = element, Next = currentNode.Next, Previous = currentNode };
            doublyLinkedNode<T> oldNodeAfterTheCurrent = currentNode.Next;

            if(oldNodeAfterTheCurrent != null)
            {
                oldNodeAfterTheCurrent.Previous = newNode;
            }
            currentNode.Next = newNode;

            if(currentNode == Tail)
            {
                Tail = newNode;
            }

            

        }

        public void DeleteNode(doublyLinkedNode<T> head, int position)
        {
            doublyLinkedNode<T> current = head;
            int currentPosition = 1;

            // Traverse to find the node at the specified position
            while (current != null && currentPosition < position)
            {
                current = current.Next;
                currentPosition++;
            }

            if (current == null)
            {
                return; // Position is out of bounds
            }

            doublyLinkedNode<T> nodeToDelete = current;

            if (nodeToDelete.Previous == null)
            {
                // Deleting the head node
                Head = nodeToDelete.Next;
                if (Head != null)
                {
                    Head.Previous = null;
                }
            }
            else
            {
                nodeToDelete.Previous.Next = nodeToDelete.Next;
            }

            if (nodeToDelete.Next != null)
            {
                nodeToDelete.Next.Previous = nodeToDelete.Previous;
            }
            else
            {
                // Deleting the tail node
                Tail = nodeToDelete.Previous; //hi
            }

            Size--;
        }


    }
}
