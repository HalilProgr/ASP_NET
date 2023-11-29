namespace ASP_NET.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository Books { get; }
        Task<int> CompletedAsync();
    }
}
