using Agenda.Datos;
using Agenda.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Agenda.Pages.Categorias
{
    public class DetalleModel : PageModel
    {
		private readonly ApplicationDbContext _context;

		public DetalleModel(ApplicationDbContext context)
		{
			_context = context;
		}

		[BindProperty]
		public Categoria Categoria { get; set; }
		public async void OnGet(int id)
		{
			Categoria = await _context.Categoria.FindAsync(id);
		}
	}
}
