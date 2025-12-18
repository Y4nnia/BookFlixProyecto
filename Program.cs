using BookFlixRazor.Repository;
using BookFlixRazor.Repository.Factories;
using BookFlixRazor.Repository.IRepositorio;
using BookFlixRazor.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

//CONEXION A LA BASE DE DATOS
builder.Services.AddScoped<IDbConnectionFactory, DbConnectionRepo>();

//REPOSITORIOS
builder.Services.AddScoped<ILibroRepositorio, LibroRepositorio>();
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

//SERVICES
builder.Services.AddScoped<ILibroService, LibroService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
