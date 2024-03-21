using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVC_Book_Library.Data;
using System;
using System.Linq;

namespace MVC_Book_Library.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MVC_Book_LibraryContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MVC_Book_LibraryContext>>()))
        {
            // Look for any movies.
            if (context.Books.Any())
            {
                return;   // DB has been seeded
            }
            context.Books.AddRange(
                new Books
                {
                    Title = "The Catcher in the Rye",
                    Edition = "First Edition",
                    Author = "J.D Salinger",
                    Genre = "Coming of age Story",
                    ReleaseDate = DateTime.Parse("1951-7-16"),
                    AddedDate = DateTime.Parse("2016-2-12"),
                    Price = 11.99M
                },
                new Books
                {
                    Title = "1984",
                    Edition = "First Edition",
                    Author = "George Orwell",
                    Genre = "Dystopian Fiction",
                    ReleaseDate = DateTime.Parse("1949-6-8"),
                    AddedDate = DateTime.Parse("2016-2-16"),
                    Price = 8.99M
                },
                new Books
                {
                    Title = "Harry Potter and the Philosopher's Stone",
                    Edition = "First Edition",
                    Author = "J.K Rowling",
                    Genre = "Young Adult Fiction",
                    ReleaseDate = DateTime.Parse("1997-6-26"),
                    AddedDate = DateTime.Parse("2016-2-12"),
                    Price = 10.99M
                },
                new Books
                {
                    Title = "Harry Potter and the Chamber of Secrets",
                    Edition = "First Edition",
                    Author = "J.K Rowling",
                    Genre = "Young Adult Fiction",
                    ReleaseDate = DateTime.Parse("1998-7-2"),
                    AddedDate = DateTime.Parse("2016-2-12"),
                    Price = 11.99M
                },
                new Books
                {
                    Title = "To Kill A Mockingbird",
                    Edition = "50th Anniversary Edition",
                    Author = "Harper Lee",
                    Genre = "Fiction",
                    ReleaseDate = DateTime.Parse("1960-7-11"),
                    AddedDate = DateTime.Parse("2017-1-22"),
                    Price = 12.95M
                },
                new Books
                {
                    Title = "The Great Gatsby",
                    Edition = "First Edition",
                    Author = "F Scott Fitzgerald",
                    Genre = "Tragic Fiction",
                    ReleaseDate = DateTime.Parse("1925-4-10"),
                    AddedDate = DateTime.Parse("2017-1-22"),
                    Price = 9.99M
                },
                new Books
                {
                    Title = "Diary of a Wimpy Kid: Rodrick Rules",
                    Edition = "First Edition",
                    Author = "Jeff Kinney",
                    Genre = "Children's Literature",
                    ReleaseDate = DateTime.Parse("2008-2-1"),
                    AddedDate = DateTime.Parse("2016-10-5"),
                    Price = 7.99M
                },
                new Books
                {
                    Title = "Diary of a Wimpy Kid: The Last Straw",
                    Edition = "First Edition",
                    Author = "Jeff Kinney",
                    Genre = "Children's Literature",
                    ReleaseDate = DateTime.Parse("2009-1-13"),
                    AddedDate = DateTime.Parse("2016-10-5"),
                    Price = 8.99M
                },
                new Books
                {
                    Title = "Diary of a Wimpy Kid: Dog Days",
                    Edition = "First Edition",
                    Author = "Jeff Kinney",
                    Genre = "Children's Literature",
                    ReleaseDate = DateTime.Parse("2009-10-12"),
                    AddedDate = DateTime.Parse("2016-10-5"),
                    Price = 8.99M
                },
                new Books
                {
                    Title = "Diary of a Wimpy Kid: The Ugly Truth",
                    Edition = "First Edition",
                    Author = "Jeff Kinney",
                    Genre = "Children's Literature",
                    ReleaseDate = DateTime.Parse("2010-11-9"),
                    AddedDate = DateTime.Parse("2016-10-5"),
                    Price = 9.99M
                }
            );
            context.SaveChanges();
        }
    }
}