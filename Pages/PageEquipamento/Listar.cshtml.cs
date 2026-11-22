using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;


namespace Obligatorio.Pages.PageEquipamiento
{
    public class ListarModel : PageModel
    {
        public List<Equipamiento> Lista { get; set; }

        public void OnGet()
        {
            Controladora unaControladora = new Controladora();
            Lista = unaControladora.ListarEquipamiento();
        }
    }
}
