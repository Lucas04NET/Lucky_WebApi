using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuckySystem_Api.Entities
{
    public class MembersDTO
    {
        [Range(0, int.MaxValue, ErrorMessage = "El ID no puede ser negativo.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DisplayName("Nombre")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DisplayName("Apellido")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DisplayName("Telefono")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El {0} es obligatorio")]        
        public string? Correo { get; set; }        
        public DateTime FechaAlta { get; set; }
        public int PaysId { get; set; } 
        public int MembershipsId { get; set; } 
        public bool CanAcces { get; set; }
        public bool Active { get; set; }
    }
}
