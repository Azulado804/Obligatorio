using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;

namespace Obligatorio.Pages.PageEquipamiento
{
    public class ActualizarStockModel : PageModel
    {
        public string Mensaje { get; set; }
        public List<Equipamiento> ListaEquipamientos { get; set; }

        public void OnGet()
        {
            Controladora unaControladora = new Controladora();
            ListaEquipamientos = unaControladora.ListarEquipamiento();
        }

        public IActionResult OnPostActualizar()
        {
            try
            {
                if (Request.Form["equipamientoId"] == "")
                {
                    throw new Exception("Debe elegir un Equipamiento");
                }
                if (Request.Form["cantidad"] == "")
                {
                    throw new Exception("Debe ingresar la Cantidad");
                }

                int equipamientoId = int.Parse(Request.Form["equipamientoId"]);
                int cantidad = int.Parse(Request.Form["cantidad"]);

                Controladora unaControladora = new Controladora();
                unaControladora.ActualizarStockEquipamiento(equipamientoId, cantidad);

                return Redirect("/PageEquipamiento/ActualizarStock");
            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
                Controladora unaControladora = new Controladora();
                ListaEquipamientos = unaControladora.ListarEquipamiento();
                return Page();
            }
        }
    }
}
