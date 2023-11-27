using Agenda.Datos;
using Agenda.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Pages.Categorias
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias { get; set; }
        
        public async Task OnGet()
        {
            Categorias = await _context.Categoria.ToListAsync();
        }
    }
}
