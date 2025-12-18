using Microsoft.AspNetCore.Mvc.RazorPages;
using BookFlixRazor.Models;
using BookFlixRazor.Services;

namespace BookFlixRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILibroService _libroService;

        public IndexModel(ILibroService libroService)
        {
            _libroService = libroService;
        }

        public IEnumerable<Libro> Libros { get; set; } = [];

        public void OnGet(string? q)
        {
            var libros = _libroService.ObtenerTodos();
            if (!string.IsNullOrWhiteSpace(q))
            {
                Libros = libros.Where(l =>
                    l.Titulo.Contains(q, StringComparison.OrdinalIgnoreCase) ||
                    l.Autor.Contains(q, StringComparison.OrdinalIgnoreCase)
                );
            }
            else
            {
                Libros = libros;
            }
        }
    }
}