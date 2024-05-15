using Fiorello_PB101.Data;
using Fiorello_PB101.Models;
using Fiorello_PB101.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_PB101.Services
{
    public class BlogService : IBlogService
    {
        private readonly AppDbContext _context;
        public BlogService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Blog>> GetAllAsync()
        {
            return await _context.Blogs.ToListAsync();
        }
    }
}
