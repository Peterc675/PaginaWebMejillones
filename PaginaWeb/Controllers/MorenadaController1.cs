using Microsoft.AspNetCore.Mvc;

public class MorenadaController : Controller
{
    // Acción para la vista Historia
    public IActionResult Historia()
    {
        ViewData["Title"] = "Historia";
        ViewData["BodyClass"] = "historia-bg";
        return View();
    }

 


    // Acción para la vista Contacto
    public IActionResult Contacto()
    {
        ViewData["Title"] = "Contacto";
        ViewData["BodyClass"] = "contacto-bg";
        return View();
    }

    // Acción para la vista Eventos
    public IActionResult Eventos()
    {
        ViewData["Title"] = "Eventos";
        ViewData["BodyClass"] = "eventos-bg";
        return View();
    }

    // Acción para la vista Galería
    public IActionResult Galeria()
    {
        ViewData["Title"] = "Galería";
        ViewData["BodyClass"] = "galeria-bg";
        return View();
    }
  

        // Accion vista Inicio
    public IActionResult Inicio()
    {
            ViewData["Title"] = "Inicio";
            ViewData["BodyClass"] = "inicio-bg";
            return View();
        }
    // Accion vista Directorio
    public IActionResult Directorio()
    {
        ViewData["Title"] = "Directorio";
        ViewData["BodyClass"] = "directorio-bg";
        return View();
    }

}


