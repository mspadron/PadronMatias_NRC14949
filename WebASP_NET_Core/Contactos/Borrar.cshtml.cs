using Agenda.Datos;
using Agenda.Models;
using Agenda.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Pages.Contactos
{
    public class BorrarModel : PageModel
    {
		private readonly ApplicationDbContext _context;
		public BorrarModel(ApplicationDbContext context)
		{
			_context = context;
		}

		[BindProperty]
		public CrearContactoVM ContactoVm { get; set; }

		public async Task<IActionResult> OnGet(int id)
		{
			ContactoVm = new CrearContactoVM()
			{
				listaCategorias = await _context.Categoria.ToListAsync(),
				Contacto = await _context.Contacto.FindAsync(id)

			};
			return Page();
		}

		public async Task<IActionResult> OnPost()
		{

			var contacto = await _context.Contacto.FindAsync(ContactoVm.Contacto.Id);
			if (contacto == null)
			{
				return NotFound();
			}

			_context.Contacto.Remove(contacto);
			await _context.SaveChangesAsync();
			return RedirectToPage("Index");

		}
	}
}
