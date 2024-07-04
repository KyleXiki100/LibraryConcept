using LibraryConcept;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
   

    private static void Main(string[] args)
    {
        BookManagement bookManagement = new BookManagement();
        
        do
        {

           

            Console.WriteLine("1. Add Book to the Library");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Search Book");
            Console.WriteLine("4. Return Book");
           


            Console.Write("Enter your choice: ");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Enter Book title");
                    string bookTitle = Console.ReadLine();
                    Console.WriteLine("Enter Author title");
                    string bookAuthor = Console.ReadLine();
                    Console.WriteLine("Enter ISBN title");
                    string bookISBN = Console.ReadLine();

                    Book newBook = new Book(bookTitle, bookAuthor, bookISBN);
                    bookManagement.AddBook(newBook);
                    break;
                case 2:
                    Console.WriteLine("Enter the book you would like to remove");
                    string bookRemoval = Console.ReadLine();
                    string result2 = bookManagement.RemoveBook(bookRemoval);
                    Console.WriteLine(result2);
                    break;

                   
                   
            }





        } while (true);

    }
}