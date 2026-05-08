namespace LuckySystem_Api.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string? Correo { get; set; }        
        public DateTime FechaAlta { get; set; }
        public IEnumerable<Payments> Pays { get; set; } = Enumerable.Empty<Payments>();
        public IEnumerable<Membership> Membership { get; set; } = Enumerable.Empty<Membership>();
        public bool CanAcces { get; set; }
        public bool Active { get; set; } = true;
    }
}
