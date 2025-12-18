using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookFlixRazor.Services;

namespace BookFlixRazor.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IUsuarioService _usuarioService;
        [BindProperty]
        public string Correo { get; set; } = "";
        [BindProperty]
        public string Password { get; set; } = "";
        public string? Mensaje { get; set; }

        public LoginModel(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            var usuario = _usuarioService.Login(Correo, Password);
            if (usuario == null)
            {
                Mensaje = "Correo o contraseña incorrectos.";
                return Page();
            }

        
            return RedirectToPage("/Index");
        }
    }
}