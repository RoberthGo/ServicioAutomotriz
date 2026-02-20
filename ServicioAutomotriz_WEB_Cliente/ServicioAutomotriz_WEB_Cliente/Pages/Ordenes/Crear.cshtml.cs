using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ServicioAutomotriz_WEB_Cliente.Pages.Ordenes
{
    public class CrearModel : PageModel
    {
        [BindProperty]
        public OrdenInput Input { get; set; } = new();

        public void OnGet()
        {
            Input.EntryDate = DateTime.Now;
            Input.EstimatedDeliveryTime = DateTime.Now.AddDays(1);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            // TODO: guardar la orden en la base de datos
            TempData["Mensaje"] = "Orden registrada correctamente.";
            return RedirectToPage("/Index");
        }
    }

    public class OrdenInput
    {
        public DateTime EntryDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "El RFC del cliente es obligatorio.")]
        [StringLength(13, MinimumLength = 12, ErrorMessage = "El RFC debe tener entre 12 y 13 caracteres.")]
        public string RFC { get; set; } = string.Empty;

        [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede superar 100 caracteres.")]
        public string CustomerName { get; set; } = string.Empty;

        [Required(ErrorMessage = "El número de serie del vehículo es obligatorio.")]
        [StringLength(50, ErrorMessage = "El número de serie no puede superar 50 caracteres.")]
        public string SerialNumber { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "La descripción no puede superar 100 caracteres.")]
        public string VehicleDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha estimada de entrega es obligatoria.")]
        public DateTime EstimatedDeliveryTime { get; set; } = DateTime.Now.AddDays(1);
    }
}
