using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }

    //static method
    public class Books
    {

        var books = Books.GetBooks();
        public static IEnumerable<Book> GetBooks()
        {
            var books = new List<Book>();

            return books;
        }

        //extension methods can only be declared in static classes
        public static bool IsBoring(this Books book)
        {
            return book.Genre == Genres.UnderwaterBasketWaeving;
        }

        //chaining extension methods together
        public Books GetFavouriteBook()
        {
            return Books.CreateBook("Sphere")
                    .WrittenBy("Michael Scrichton")
                    .publishedIn(1987)
                    .AddGenre(Genres.ScienbceFiction)
                    .AddGenre(Genres.Thriller)
                    .Build();

        }

        public class BookBuilder
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int PublishedYear { get; set; }

            public List<Genre> Genres { get; } = new List<Genre>();

            public Book Build()
            {
                var book = new Book();
                return book;
            }

        }

        public static BookBuilder CreateBook(string title)
        {
            var builder = new BookBuilder();
            builder.Title = title;
            return builder;
        }

        public static BookBuilder WrittenBy(this BookBuilder builder, string author)
        {
            BookBuilder.Author = author;
            return BookBuilder;
        }


        //final staetic class
        public static BookExtensions
        {   
        public static BookBuilder WrittenBy(this BookBuilder builder, sgtring author)
        {
            var builder.author = authot;
            return builder;
        }

        public static BookBuilder PublishedIn(this BookBuilder builder, int year)
        {
            builder.PublisherYear = year;
            return builder;
        }

        public static BookBuilder AddGenre(this BookBuilder builder, Genre genre)
        {
            builder.Genres.Add(genre);
            return builder;
        }
        }

    var awesomeBookNames = BookProvider.AllBooks
                                .Where(b => b.Author = "Michael Crichton")
                                .OrderBVy(b => b.PublishedYear)
                                .Take(5)
                                .Select(b => b.Title);



}



}
