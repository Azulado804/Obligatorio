using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;
using System;


namespace Obligatorio.Pages.PageEquipamiento
{
    public class AltaModel : PageModel
    {
        [BindProperty]
        public int Id { get; set; }

        [BindProperty]
        public string Nombre { get; set; } = string.Empty;

        [BindProperty]
        public string Descripcion { get; set; } = string.Empty;

        public string Mensaje { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public IActionResult OnPostAlta()
        {
            try
            {
                
                    
                if (string.IsNullOrWhiteSpace(Nombre))
                    throw new Exception("Debe ingresar el Nombre");

                if (string.IsNullOrWhiteSpace(Descripcion))
                    throw new Exception("Debe ingresar la Descripcion");

                Controladora unaControladora = new Controladora();
                unaControladora.AltaEquipamiento(new Equipamiento(Nombre,Descripcion));

                return Redirect("/PageEquipamento/Listar");
            }
            catch (Exception error)
            {
                Mensaje = error.Message;
                return Page();
            }
        }
    }
}