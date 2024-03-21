using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Book_Library.Models;

namespace MVC_Book_Library.Data
{
    public class MVC_Book_LibraryContext : DbContext
    {
        public MVC_Book_LibraryContext (DbContextOptions<MVC_Book_LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Book_Library.Models.Books> Books { get; set; } = default!;
    }
}
