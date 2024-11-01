using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pim8.Data;
using Pim8.Models;

namespace Pim8.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Pim8.Data.ApplicationDbContext _context;

        public IndexModel(Pim8.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Produto = await _context.Produtos.ToListAsync();
        }
    }
}
