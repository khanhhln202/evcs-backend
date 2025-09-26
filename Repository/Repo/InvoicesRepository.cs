using DAL.DBcontext;
using Repository.Basic;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repo
{
    public class InvoicesRepository : GenericRepository<Invoices>
    {
        public InvoicesRepository() { }
        public InvoicesRepository(EVCSDBContext context) => _context = context;
    }
}
