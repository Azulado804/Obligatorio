using Obligatorio.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Obligatorio.Pages.PageCliente
{
    public class ModificarModel : PageModel
    {
        public Cliente cliente {  get; set; }
        public string Mensaje { get; set; } = "";
        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            cliente = unaControladora.BuscarCliente(id);
        }
        public IActionResult OnPostModificar()
        {
            try
            {
                if (Request.Form["id"] == "")
                {
                    throw new Exception("Debe ingresar el ID del Cliente");
                }
                if (!int.TryParse(Request.Form["id"], out _))
                {
                    throw new Exception("El ID del Cliente debe ser un numero");
                }
                if (Request.Form["nombre"] == "")
                {
                    throw new Exception("Debe ingresar el Nombre del Cliente");
                }
                if (Request.Form["Documento"] == "")
                {
                    throw new Exception("Debe ingresar el Documento del Cliente");
                }
                if (Request.Form["Email"] == "")
                {
                    throw new Exception("Debe ingresar el Email del Cliente");
                }
                if (Request.Form["direccion"] == "")
                {
                    throw new Exception("Debe ingresar Dirección del Cliente");
                }
                if (Request.Form["telefono"] == "")
                {
                    throw new Exception("Debe ingresar el Teléfono del Cliente");
                }

                int Id = int.Parse(Request.Form["id"]);
                string Nombre = Request.Form["nombre"];
                string Documento = Request.Form["documento"];
                string Email = Request.Form["email"];
                string Direccion = Request.Form["direccion"];
                string Telefono = Request.Form["telefono"];

                Controladora unaControladora = new Controladora();

                unaControladora.ModificarCliente(Id, Nombre, Documento, Direccion, Telefono, Email);
                return Redirect("/PageCliente/Listar");

            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
                return Page();
            }
        }
    }
}
