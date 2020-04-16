using System.Threading.Tasks;
using Core;
using Data.EfContext;

namespace Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly KoodleDbContext _context;

        public UnitOfWork(KoodleDbContext context)
        {
            _context = context;
        }
        
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}