using LuckySystem_Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace LuckySystem_Api.Data
{
    public class LuckyGym_Context : DbContext
    {
        public LuckyGym_Context(DbContextOptions<LuckyGym_Context> options) : base(options)
        {
            
        }
        public DbSet<Member> Member { get; set; }
        public DbSet<Membership> Membership { get; set; }
        public DbSet<Payments> Payments { get; set; }

    }
}
