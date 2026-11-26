using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;

namespace Obligatorio.Pages.PageEquipamiento
{
    public class EliminarModel : PageModel
    {
        public Equipamiento? equipamiento { get; set; }
        public List<Equipamiento> Lista { get; set; } = new();

        public void OnGet(int? id)
        {
            Controladora unaControladora = new Controladora();
            Lista = unaControladora.ListarEquipamiento();
            if (id.HasValue)
            {
                equipamiento = unaControladora.BuscarEquipamiento(id.Value);
            }
        }

        public IActionResult OnPostEliminar()
        {
            int id = int.Parse(Request.Form["id"]);

            Controladora unaControladora = new Controladora();
            unaControladora.BajaEquipamiento(id);
            return Redirect("./Listar");
        }
    }
}
