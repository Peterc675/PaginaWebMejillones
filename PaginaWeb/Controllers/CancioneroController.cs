using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace PaginaWeb.Controllers
{
    public class CancioneroController : Controller
    {
        // Lista de canciones con información básica
        private static List<dynamic> canciones = new List<dynamic>
        {
            new
            {
                Id = 1,
                Titulo = "El Camionero",
                Autor = "Letra y Música: Eloy Apaza Ch.",
                VideoUrl = "https://www.youtube.com/embed/5ubanT-5qQs"
            },
            new
            {
                Id = 2,
                Titulo = "Soy de Mejillones",
                Autor = "Letra y Música: Eloy Apaza Ch.",
                VideoUrl = "https://www.youtube.com/embed/1Wjiw1G2k9s"
            },
            new
            {
                Id = 3,
                Titulo = "Rey de los Caminos",
                Autor = "Letra y Música: Santiago Paucara",
                VideoUrl = "https://www.youtube.com/embed/3Z0TxtWsrVk"
            },
            new
            {
                Id = 4,
                Titulo = "En la Soledad",
                Autor = "Letra y Música: Edgar Rojas Cazasola",
                VideoUrl = "https://youtu.be/swdPqXgwW3Y. "
            },
            new
            {
                Id = 5,
                Titulo = "Ya llego la pesada",
                Autor = "Letra y Música: Edgar Rojas Cazasola",
                VideoUrl = "https://www.youtube.com/embed/ZQfC6pTFhqo"
            },
            new
            {
                Id = 6,
                Titulo = "Nuestras Penas",
                Autor = "Letra y Música: Luis Tindal",
                VideoUrl = "https://www.youtube.com/embed/fydDjaq5ITc"
            },
             new
            {
                Id = 7,
                Titulo = "Orureñita",
                 Autor = "Letra y Música: Luis Tindal",
                VideoUrl = "https://www.youtube.com/embed/1yjFSlveVKI"

            },
              new
            {
                Id = 8,
                Titulo = "Que cosa voy a llevar",
                Autor = "Letra y Música: Santiago Paucara",
                VideoUrl = "https://www.youtube.com/embed/XrTtQBvQHZM"
            },
              new
            {
                Id = 9,
                Titulo = "Viva la Mejillones",
                Autor = "Letra y Música: Gumercindo Licidio",
                VideoUrl = "https://www.youtube.com/embed/MGXxoaUQ8Bk"
            },
              new
            {
                Id = 10,
                Titulo = "Prometi",
                Autor = "Letra y Música: Teodoro Paucara",
                VideoUrl = "https://www.youtube.com/embed/281LWhmNitw"
            },
              new
            {
                Id = 11,
                Titulo = "La Pesada",
                Autor = "Letra y Música: Gumercindo Licidio",
                VideoUrl = "https://www.youtube.com/embed/qZ53rjbZ-HI"
            },
              new
            {
                Id = 12,
                Titulo = "Transportista Soy",
                Autor = "Letra y Música: Cristian Mamani Condori",
                VideoUrl = "https://www.youtube.com/embed/dzf3Xh1U6ts"
            },
              new
            {
                Id = 13,
                Titulo = "Beso de Negro",
                Autor = "Letra y Música: Luis Alberto Aguilar",
                VideoUrl = "https://www.youtube.com/embed/glCfH7XktKY"
            },
              new
            {
                Id = 14,
                Titulo = "Prueba de Amor",
                Autor = "Letra y Música: Denis Breyton Pérez Quisbert",
                VideoUrl = "https://www.youtube.com/embed/81a6rHC9v6I"
            },
              new
            {
                Id = 15,
                Titulo = "La Pesada Mejillones",
                Autor = "Letra y Música: Edgar Rojas Casazola",
                VideoUrl = "https://www.youtube.com/embed/39qGbhug4X4"
            },
              new
            {
                Id = 16,
                Titulo = "Moreno Enamorado",
                Autor = "Letra y Música: Milton Quiroga",
                VideoUrl = "https://www.youtube.com/embed/e4-X3UzjfkU"
            },
              new
            {
                Id = 17,
                Titulo = "Amor Amor",
                Autor = "Letra y Música: A.A.D.D. SOBODAYCOM",
                VideoUrl = "https://www.youtube.com/embed/QT9x9eYgy-E"
            },
              new
            {
                Id = 18,
                Titulo = "Oh Dudas De Mi",
                Autor = "Letra y Musica: Juan Tinti Apaza",
                VideoUrl = "https://www.youtube.com/embed/_YU51dGyIlE"
            },
              new
            {
                Id = 19,
                Titulo = "Regresaras Lorando",
                Autor = "Letra: Grupo wiñay Musica A.A.D.D. SOBODAYCOM",
                VideoUrl = "https://www.youtube.com/embed/_YU51dGyIlE"
            },
              new
            {
                Id = 20,
                Titulo = "Los Pulpos",
                Autor = "Letra y Musica: A.A.D.D. SOBODAY",
                VideoUrl = "https://www.youtube.com/embed/qUDm3_e95Ew"
            },
              new
            {
                Id = 21,
                Titulo = "La Chascañawi",
                Autor = "Letra y Música: Rafel Arias Paz",
                VideoUrl = "https://www.youtube.com/embed/ltUMVgC5Y68"
            },


        };

        // Acción para mostrar el índice de canciones
        public IActionResult Index()
        {
            return View(canciones);
        }

        // Acción para mostrar los detalles de una canción
        public IActionResult Detalle(int id)
        {
            var cancion = canciones.FirstOrDefault(c => c.Id == id);

            if (cancion == null)
                return NotFound();

            return View(cancion);
        }
    }
}
