# 📚 Proyecto TP – Bookflix (Razor Pages)

---

## 👥 Integrantes del grupo
- **Casimiro Enzo**
- **Sofía Gonzalez**
- **Yanina Piuca**

---
📘 1. Misión

Permitir a los usuarios acceder a una amplia variedad de libros digitales que puedan comprar y leer desde cualquier dispositivo. La plataforma facilita guardar libros favoritos, realizar compras sin necesidad de ir a una librería física y ahorrar tiempo; además, promueve la lectura mediante un entorno totalmente digital.

🛠️ Tecnologías Utilizadas
Tecnología  Uso
ASP.NET Core 9 (Razor Pages)    Backend + Frontend
C#  Lógica del sistema
JSON / MySQL

👨‍💻 Estructura y Explicación Técnica

📌 Program.cs

Configura servicios de Razor Pages.

Configura sesión para manejo de carrito y usuario logueado.

Inyección de dependencias para RegistroService y LibroService.

Configura rutas, middlewares y seguridad básica.


📌 Pages

Las Razor Pages se organizan por módulos: Index, Login, Registro, Carrito, LibroDetalle.

Cada página tiene su PageModel con la lógica OnGet / OnPost.

Libros cargados desde JSON (wwwroot/data/libros.json) o MySQL.

Categorías dinámicas generadas automáticamente.

Filtrado de libros por título, autor y categoría.

Carrito manejado con sesión y mensajes con TempData.

Registro de usuarios con validaciones y login con sesión activa.

Estilos con Bootstrap 5 para formularios, botones y tarjetas de libros.

🔹 Funcionalidades

✅ Visualización de libros desde JSON o base de datos.

✅ Búsqueda de libros por título o autor.

✅ Filtrado por categorías dinámicas.

✅ Carrito de compras en sesión con cantidad y total calculado.

✅ Registro de usuarios con validaciones:

Correo Gmail obligatorio.

Contraseña mínima de 6 caracteres.

✅ Inicio de sesión y sesión activa del usuario.

✅ Mensajes de error y éxito dinámicos en la UI.

✅ Interfaz amigable, responsive y moderna con Bootstrap 5.

##  Lista de Tareas

Tarea | Descripción | Duración (Dias) | Precedencia | Encargados |
|------|-------------|----------|-------------|------------|
| A | Crear repositorio GitHub | 1  | –––– | Enzo Casimiro |
| B | Crear proyecto en HTML (estructura básica) | 3 | –––– | Enzo Casimiro |
| C | Crear proyecto en Razor Pages | 1 | B | Enzo Casimiro |
| D | Implementar contenido HTML en Razor Pages | 2 | C | Enzo Casimiro, Yanina Piuca, Sofía Gonzalez |
| E | Crear login/registro de usuario | 3| C | Enzo Casimiro |
| F | Modificar pantalla principal | 3 | E | Sofía Gonzalez, Yanina Piuca, Enzo Casimiro |
| G | Agregar libros a la pantalla principal | 4 | F | Yanina Piuca, Enzo Casimiro, Sofía Gonzalez |
| H | Botón “Ver más” (más info del libro) | 1 | G | Enzo Casimiro |
| I | Agregar filtros por categoría | 2 | G | Enzo Casimiro, Yanina Piuca, Sofía Gonzalez |
| J | Agregar buscador | 2  | G | Enzo Casimiro |
| K | Agregar diseño | 4 | F | Sofía Gonzalez, Yanina Piuca |
| L | Crear Base de Datos | 5 | B, C | Enzo Casimiro |

---

Duración total estimada: **10.25 horas**


### **Gantt**

```mermaid

gantt
    title BookFlix
    dateFormat DD
    axisFormat Día %D
    
    section Crea Repositorio GitHub
    A : A, 01, 1d
    
    section Crea Proyecto HTML
    B : B, after A, 3d
    
    section Crea Proyecto Razor Pages
    C : C, after B, 1d
    
    section Implementa HTML en Razor Pages
    D : D, after C, 2d
    
    section Crea Login/Registro Usuario
    E : E, after C, 3d
    
    section Modifica Pantalla Principal
    F : F, after E, 3d
    
    section Agrega Libros a Pantalla Principal
    G : G, after F, 4d
    
    section Agrega Botón "Ver más"
    H : H, after G, 1d
    
    section Agrega Filtros por Categoría
    I : I, after G, 2d
    
    section Agrega Buscador
    J : J, after G, 2d
    
    section Agrega Diseño
    K : K, after F, 4d

    section Crea Base de Datos
    L : L, after C, 5d
---

## 📄 Descripción general
Proyecto creado con **ASP.NET Razor Pages**, con gestión de libros, login, filtros, buscador y base de datos propia.

---
