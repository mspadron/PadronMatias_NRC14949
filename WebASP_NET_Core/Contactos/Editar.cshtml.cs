using Agenda.Datos;
using Agenda.Models;
using Agenda.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Pages.Contactos
{
    public class EditarModel : PageModel
    {
		private readonly ApplicationDbContext _context;
		public EditarModel(ApplicationDbContext context)
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
			if (ModelState.IsValid)
			{
				var ContactoDesdeDB = await _context.Contacto.FindAsync(ContactoVm.Contacto.Id);
				ContactoDesdeDB.Nombre = ContactoVm.Contacto.Nombre;
				ContactoDesdeDB.Email = ContactoVm.Contacto.Email;
				ContactoDesdeDB.Telefono = ContactoVm.Contacto.Telefono;
				ContactoDesdeDB.CategoriaId = ContactoVm.Contacto.CategoriaId;
				ContactoDesdeDB.FechaCreacion = ContactoVm.Contacto.FechaCreacion;


			
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
