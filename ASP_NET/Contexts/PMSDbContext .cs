using ASP_NET.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class BookContext : DbContext
{
    public class PMSDbContext : DbContext
    {
        public PMSDbContext(DbContextOptions<PMSDbContext> options)
            : base(options)
        {
        }
    public virtual DbSet<Book> Books { get; set; }
    }
}
