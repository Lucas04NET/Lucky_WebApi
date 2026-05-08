namespace LuckySystem_Api.Entities
{
    public class MembersDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string? Correo { get; set; }
        public string Doc { get; set; } = string.Empty;
        public DateTime FechaAlta { get; set; }
        public int PaysId { get; set; } 
        public int MembershipsId { get; set; } 
        public bool CanAcces { get; set; }
        public bool Active { get; set; }
    }
}
