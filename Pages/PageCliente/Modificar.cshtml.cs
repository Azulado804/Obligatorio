using Obligatorio.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Obligatorio.Pages.PageCliente
{
    public class ModificarModel : PageModel
    {
        public Cliente? cliente { get; set; }
        public string Mensaje { get; set; } = "";
        public void OnGet(int? id)
        {
            Controladora unaControladora = new Controladora();
            if (!id.HasValue)
            {
                Mensaje = "No se indicó el ID del Cliente.";
                return;
            }

            cliente = unaControladora.BuscarCliente(id.Value);
            if (cliente == null)
            {
                Mensaje = "No se encontró el Cliente indicado.";
            }
        }

        public IActionResult OnPostModificar()
        {
            try
            {
                string idFormulario = Request.Form["id"].ToString();
                string Nombre = Request.Form["nombre"].ToString();
                string Apellido = Request.Form["apellido"].ToString();
                string Direccion = Request.Form["direccion"].ToString();
                string Telefono = Request.Form["telefono"].ToString();

                if (idFormulario == "")
                {
                    throw new Exception("Debe ingresar el ID del Cliente");
                }
                if (!int.TryParse(idFormulario, out int Id))
                {
                    throw new Exception("El ID del Cliente debe ser un numero");
                }
                if (Nombre == "")
                {
                    throw new Exception("Debe ingresar el Nombre del Cliente");
                }
                if (Apellido == "")
                {
                    throw new Exception("Debe ingresar el Apellido del Cliente");
                }
                if (Direccion == "")
                {
                    throw new Exception("Debe ingresar Dirección del Cliente");
                }
                if (Telefono == "")
                {
                    throw new Exception("Debe ingresar el Teléfono del Cliente");
                }

                Controladora unaControladora = new Controladora();

                if (!unaControladora.ModificarCliente(Id, Nombre, Apellido, Direccion, Telefono))
                {
                    throw new Exception("No se encontró el Cliente indicado.");
                }

                return Redirect("/PageCliente/Listar");

            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
                if (int.TryParse(Request.Form["id"], out int id))
                {
                    cliente = new Controladora().BuscarCliente(id);
                    if (cliente == null)
                    {
                        Mensaje = "No se encontró el Cliente indicado.";
                    }
                }
                return Page();
            }
        }
    }
}
