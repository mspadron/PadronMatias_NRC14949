using Agenda.Datos;
using Agenda.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Pages.Contactos
{
    public class IndexModel : PageModel
    {
		private readonly ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context)
        {
			_context = context;
		}

		public IEnumerable<Contacto> Contactos { get; set; }
		public async Task OnGet()
        {
			Contactos = await _context.Contacto.Include(c => c.Categoria ).ToListAsync();

		}
    }
}
