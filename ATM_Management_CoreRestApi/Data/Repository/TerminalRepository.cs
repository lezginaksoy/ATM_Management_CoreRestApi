using ATM_Management_CoreRestApi.Data.Interface;
using ATM_Management_CoreRestApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Management_CoreRestApi.Data.Repository
{
    public class TerminalRepository : Repository<Terminal>, ITerminalRepository
    {

        public TerminalRepository(AtmManagmentContext Context) : base(Context)
        {
        }
        
        public IEnumerable<Terminal> FindWithBrand(Func<Terminal, bool> predicate)
        {
            return _context.Terminals
                .Include(a => a.BrandId)
                .Where(predicate);
        }

        public IEnumerable<Terminal> FindWithCode(Func<Terminal, bool> predicate)
        {
            return _context.Terminals
                .Include(a => a.TerminalCode)
                .Where(predicate);
        }

        public IEnumerable<Terminal> GetAllWithCode()
        {
            return _context.Terminals.Include(a => a.TerminalCode);
        }
    }
}
