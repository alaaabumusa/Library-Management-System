using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Library
    {
        private List<Book> Books = new List<Book>();
        private List<AbstractPerson> Members = new List<AbstractPerson>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddMember(AbstractPerson member)
        {
            Members.Add(member);
        }

        public Book FindBookById(int id)
        {
            return Books.FirstOrDefault(b => b.Id == id);
        }

        public AbstractPerson FindMemberById(int id)
        {
            return Members.FirstOrDefault(m => m.Id == id);
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("\n--- All Books ---");
            foreach (var book in Books)
            {
                book.DisplayInfo();
            }
        }

        public void DisplayAllMembers()
        {
            Console.WriteLine("\n--- All Members ---");
            foreach (var member in Members)
            {
                member.DisplayInfo();
            }
        }
    }


}
