using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Repuestos2023.Models.Models
{
    public class Proveedor
    {
        [Key]
        public int ProveedorId { get; set; }
        [Required]
        [DisplayName("Proveedor")]
        public string NombreProveedor { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
