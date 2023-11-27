using Agenda.Datos;
using Agenda.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Agenda.Pages.Categorias
{
	public class CrearModel : PageModel
	{

		private readonly ApplicationDbContext _context;

		public CrearModel(ApplicationDbContext context)
		{
			_context = context;
		}

		[BindProperty]
		public Categoria Categoria { get; set; }

		public void OnGet()
        {
        }

		public async Task<IActionResult> OnPost()
		{
			if (ModelState.IsValid)
			{
				await _context.Categoria.AddAsync(Categoria);
				await _context.SaveChangesAsync();
				return RedirectToPage("Index");
			} else
			{
				return Page();
			}
		}
    }
}
