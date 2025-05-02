using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Member : AbstractPerson
    {
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();

        public Member(int id, string name) : base(id, name) { }

        public void BorrowBook(Book book)
        {
            if (book != null && book.IsAvailable)
            {
                BorrowedBooks.Add(book);
                book.IsAvailable = false;
                Console.WriteLine($"Book '{book.Title}' borrowed successfully.");
            }
            else
            {
                Console.WriteLine("Book is not available.");
            }
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                book.IsAvailable = true;
                Console.WriteLine($"Book '{book.Title}' returned successfully.");
            }
            else
            {
                Console.WriteLine("Book is not in borrowed list.");
            }
        }

        public void DisplayBorrowedBooks()
        {
            Console.WriteLine($"\nBorrowed Books by {Name}:");
            if (BorrowedBooks.Count == 0)
            {
                Console.WriteLine("No books borrowed.");
            }
            else
            {
                foreach (var book in BorrowedBooks)
                {
                    book.DisplayInfo();
                }
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {Id}, Name: {Name}");
        }
    }

}
