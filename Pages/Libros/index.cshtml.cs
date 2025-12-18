using Microsoft.AspNetCore.Mvc.RazorPages;
using BookFlixRazor.Models;
using BookFlixRazor.Services;

namespace BookFlixRazor.Pages.Libros
{
    public class IndexModel : PageModel
    {
        private readonly ILibroService _libroService;

        public IndexModel(ILibroService libroService)
        {
            _libroService = libroService;
        }

        public IEnumerable<Libro> Libros { get; set; } = [];

        public void OnGet()
        {
            Libros = _libroService.ObtenerTodos();
        }
    }
}
