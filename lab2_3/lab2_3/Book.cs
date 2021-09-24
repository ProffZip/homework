using System;
using System.Runtime.CompilerServices;

public class Book
{
    
    public void BookInfo()
    {
        Title bookTitle = new Title();
        Console.WriteLine("Enter the book Title:");
        bookTitle.BookTitle = Console.ReadLine();
        Author bookAuthor = new Author();
        Console.WriteLine("Enter the book Author");
        bookAuthor.BookAuthor = Console.ReadLine();
        Content bookContent = new Content();
        Console.WriteLine("Enter the book Content");
        bookContent.BookContent =Console.ReadLine();
        bookTitle.Show();
        bookAuthor.Show();
        bookContent.Show();
        Console.ReadLine();
    }
}
