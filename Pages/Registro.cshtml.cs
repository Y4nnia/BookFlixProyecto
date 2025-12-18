using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookFlixRazor.Models;
using BookFlixRazor.Services;

namespace BookFlixRazor.Pages
{
    public class RegistroModel : PageModel
    {
        private readonly IUsuarioService _usuarioService;
        [BindProperty]
        public Usuario Usuario { get; set; } = new();
        public string? Mensaje { get; set; }

        public RegistroModel(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public void OnGet() { }

       public IActionResult OnPost()
     {
        if (!ModelState.IsValid)
        return Page();

         var existe = _usuarioService.ObtenerPorCorreo(Usuario.Correo);
         if (existe != null)
        {
            Mensaje = "El correo ya esta registrado";
            return Page();
        }

        var registroDto = new RegistroDTO
        {
            Nombre = Usuario.Nombre,
            Apellido = Usuario.Apellido,
            Correo = Usuario.Correo,
            Password = Usuario.Password
        };

        _usuarioService.Registrar(registroDto);
        Mensaje = "Registro exitoso, Ahora puedes iniciar sesion";
        Usuario = new();
        return Page();
      }
    }
}



