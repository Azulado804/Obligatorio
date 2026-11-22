using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;
using System.Collections.Generic;

namespace Obligatorio.Pages.PageSolicitud
{
    public class ListarModel : PageModel
    {
        public List<Solicitud> Lista { get; set; }
        public void OnGet()
        {
            Controladora unaControladora = new Controladora();
            Lista = unaControladora.ListarSolicitudes();
        }
    }
}
