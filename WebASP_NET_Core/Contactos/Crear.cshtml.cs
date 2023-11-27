using Agenda.Datos;
using Agenda.Models;
using Agenda.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Pages.Contactos
{
    public class CrearModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CrearModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CrearContactoVM ContactoVm { get; set; }

        public async Task<IActionResult> OnGet()
        {
            ContactoVm = new CrearContactoVM()
            {
                listaCategorias = await _context.Categoria.ToListAsync(),
                Contacto = new Models.Contacto()

            };
            return Page();
        }

		public async Task<IActionResult> OnPost()
		{
			if (ModelState.IsValid)
			{
				await _context.Contacto.AddAsync(ContactoVm.Contacto);
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
