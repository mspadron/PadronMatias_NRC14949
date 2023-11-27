using Agenda.Datos;
using Agenda.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Agenda.Pages.Categorias
{
    public class BorrarModel : PageModel
    {
		private readonly ApplicationDbContext _context;

		public BorrarModel(ApplicationDbContext context)
		{
			_context = context;
		}

		[BindProperty]
		public Categoria Categoria { get; set; }
		public async void OnGet(int id)
		{
			Categoria = await _context.Categoria.FindAsync(id);
		}

		public async Task<IActionResult> OnPost()
		{

				var CategoriaDesdeDB = await _context.Categoria.FindAsync(Categoria.Id);
				if (CategoriaDesdeDB == null)
				{
					return NotFound();
				}
				
				_context.Categoria.Remove(CategoriaDesdeDB);
				await _context.SaveChangesAsync();
				return RedirectToPage("Index");

		}
	}
}
