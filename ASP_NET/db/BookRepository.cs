using ASP_NET.Interfaces;
using ASP_NET.Models;
using Microsoft.EntityFrameworkCore;
using static BookContext;

namespace ASP_NET.db
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(PMSDbContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}
