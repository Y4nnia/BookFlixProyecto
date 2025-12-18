using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookFlixRazor.Models;
using BookFlixRazor.Services;

namespace BookFlixRazor.Pages.Libros
{
    public class DetalleLibroModel : PageModel
    {
        private readonly ILibroService _libroService;

        public DetalleLibroModel(ILibroService libroService)
        {
            _libroService = libroService;
        }

        public Libro? Libro { get; set; }

        public IActionResult OnGet(int id)
        {
            Libro = _libroService.ObtenerPorId(id);
            if (Libro == null)
            {
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}