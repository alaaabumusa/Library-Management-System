using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public bool IsAvailable { get; set; }

        public Book(int id, string title, string authorName)
        {
            Id = id;
            Title = title;
            AuthorName = authorName;
            IsAvailable = true;
        }

        public void DisplayInfo()
        {
            string status = IsAvailable ? "Available" : "Borrowed";
            Console.WriteLine($"Book ID: {Id}, Title: {Title}, Author: {AuthorName}, Status: {status}");
        }
    }


}
