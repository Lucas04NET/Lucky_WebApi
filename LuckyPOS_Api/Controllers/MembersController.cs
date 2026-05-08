using LuckySystem_Api.Data;
using LuckySystem_Api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LuckyPOS_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MembersController : ControllerBase
    {
        private readonly LuckyGym_Context dbContext;

        public MembersController(LuckyGym_Context dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet(Name = "GetMembers")]
        [EndpointSummary("Obtiene la lista completa de los socios.")]
        public async Task<ActionResult<IEnumerable<Member>>> GetAll()
        {
            try
            {
                var membersList = await dbContext.Member
                    .Include(p => p.Pays)
                    .Include(s => s.Membership)
                    .ToListAsync();
                return Ok(membersList);
            }
            catch
            {
                return StatusCode(500, "Ocurrió un error al obtener los socios.");
            }
        }
    }
}
