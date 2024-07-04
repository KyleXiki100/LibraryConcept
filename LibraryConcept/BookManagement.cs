using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConcept
{
    public class BookManagement
    {
        private LibraryManagement<Book> books;

        public BookManagement() {

            books = new LibraryManagement<Book>();   
            
            
        
        }

        public void AddBook(Book book)
        {
            books.InsertLast(book);
        }

        public string RemoveBook(string titleToRemove) 
        {
           int pos = FindBookPos(titleToRemove);

            if(pos == -1)
            {
                return "Book not found";
            }

            books.DeleteNode(books.Head,pos);
            return "Book has been removed";

        }

        private int FindBookPos(string Title)
        {
            doublyLinkedNode<Book> current = books.Head;
            int pos = 1;

            while (current != null)
            {
                if(current.Element.Title == Title)
                {
                    return pos;
                }
                current = current.Next;
                pos++;
            }return -1;
        }

    }
}
