using ASP_NET.Interfaces;
using static BookContext;

namespace ASP_NET.db
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PMSDbContext _context;
        private readonly ILogger _logger;
        public IBookRepository Books { get; private set; }
    public UnitOfWork(
        PMSDbContext context,
        ILoggerFactory logger
        )
        {
            _context = context;
            _logger = logger.CreateLogger("logs");
        Books = new BookRepository(_context, _logger);
        }
    public async Task<int> CompletedAsync() => await _context.SaveChangesAsync();
    public void Dispose() => _context.Dispose();
    }

}
