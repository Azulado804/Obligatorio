using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;

namespace Obligatorio.Pages.PageEquipamiento
{
    public class ModificarModel : PageModel
    {
        public Equipamiento? equipamiento { get; set; }
        public List<Equipamiento> Lista { get; set; } = new();
        public string Mensaje { get; set; } = "";

        public void OnGet(int? id)
        {
            Controladora unaControladora = new Controladora();
            Lista = unaControladora.ListarEquipamiento();
            if (id.HasValue)
            {
                equipamiento = unaControladora.BuscarEquipamiento(id.Value);
            }
        }

        public IActionResult OnPostModificar()
        {
            try
            {
                if (Request.Form["id"] == "")
                {
                    throw new Exception("Debe ingresar el ID del Equipamiento");
                }
                if (!int.TryParse(Request.Form["id"], out _))
                {
                    throw new Exception("El ID del Equipamiento debe ser un numero");
                }
                if (Request.Form["nombre"] == "")
                {
                    throw new Exception("Debe ingresar el Nombre del Equipamiento");
                }
                if (Request.Form["descripcion"] == "")
                {
                    throw new Exception("Debe ingresar la Descripcion del Equipamiento");
                }

                int id = int.Parse(Request.Form["id"]);
                string nombre = Request.Form["nombre"];
                string descripcion = Request.Form["descripcion"];

                Controladora unaControladora = new Controladora();
                unaControladora.ModificarEquipamiento(id, nombre, descripcion, 0m);
                return Redirect("/PageEquipamento/Listar");
            }
            catch (Exception error)
            {
                Mensaje = error.Message;
                Lista = new Controladora().ListarEquipamiento();
                if (int.TryParse(Request.Form["id"], out int id))
                {
                    Controladora unaControladora = new Controladora();
                    equipamiento = unaControladora.BuscarEquipamiento(id);
                }
                return Page();
            }
        }
    }
}
