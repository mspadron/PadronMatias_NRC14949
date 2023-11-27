using Agenda.Datos;
using Agenda.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Agenda.Pages.Categorias
{
    public class EditarModel : PageModel
    {
		private readonly ApplicationDbContext _context;

		public EditarModel(ApplicationDbContext context)
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
			if (ModelState.IsValid)
			{
				var CategoriaDesdeDB = await _context.Categoria.FindAsync(Categoria.Id);
				CategoriaDesdeDB.Nombre = Categoria.Nombre;
				CategoriaDesdeDB.FechaCreacion = Categoria.FechaCreacion;

				await _context.SaveChangesAsync();
				return RedirectToPage("Index");
			}
			else
			{
				return Page();
			}
		}
	}
}
