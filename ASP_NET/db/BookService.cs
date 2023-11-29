using ASP_NET.Interfaces;
using ASP_NET.Models;
using AutoMapper;

namespace ASP_NET.db
{
    public class BookService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public BookService(
            IUnitOfWork unitOfWork,
            IMapper mapper
            )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
    public async Task<IEnumerable<BookDTO>> GetProjectAsync()
        {
            var books = await _unitOfWork.Books.GetAll();

        return _mapper.Map<IEnumerable<BookDTO>>(books);
        }

    public async Task<bool> InsertAsync(BookDTO bookDTO)
        {
            var book = _mapper.Map<Book>(bookDTO);
            return await _unitOfWork.Books.Add(book);
        }

    public async Task<int> CompletedAsync()
        {
            return await _unitOfWork.CompletedAsync();
        }
    }
}
