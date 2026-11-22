using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;

namespace Obligatorio1_P3.Pages.PageSolicitud
{
    public class AltaModel : PageModel
    {
        public string Mensaje { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public void OnPost(int id, int idCliente, int idEquipamiento,
            string fechaSolicitud, string fechaInicio, string fechaFin, string estado)
        {
            if (id <= 0 || idCliente <= 0 || idEquipamiento <= 0 ||
                string.IsNullOrWhiteSpace(fechaSolicitud) ||
                string.IsNullOrWhiteSpace(fechaInicio) ||
                string.IsNullOrWhiteSpace(fechaFin) ||
                string.IsNullOrWhiteSpace(estado))
            {
                Mensaje = "Complete todos los datos correctamente";
                return;
            }

            Controladora unaControladora = new Controladora();
            Cliente? cliente = unaControladora.BuscarCliente(idCliente);
            Equipamiento? equipamiento = unaControladora.BuscarEquipamiento(idEquipamiento);

            if (cliente == null || equipamiento == null)
            {
                Mensaje = "Cliente o equipamiento no existe";
            }
            else
            {
                Solicitud solicitud = new Solicitud(
                    id, cliente, equipamiento, fechaSolicitud,
                    fechaInicio, fechaFin, estado);

                unaControladora.AgregarSolicitud(solicitud);
                Mensaje = "Solicitud creada";
            }
        }
    }
}