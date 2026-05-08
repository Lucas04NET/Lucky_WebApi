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
        private readonly ILogger<MembersController> logger;

        public MembersController(LuckyGym_Context dbContext, ILogger<MembersController> logger)
        {
            this.dbContext = dbContext;
            this.logger = logger;
        }

        [HttpGet(Name = "GetMembers")]
        [EndpointSummary("Obtiene la lista completa de los socios.")]
        public async Task<ActionResult<IEnumerable<MembersDTO>>> GetAll()
        {
            try
            {                
                var membersList = await dbContext.Member
                    .Select(m => new MembersDTO
                    {
                        Id = m.Id,
                        Name = m.Name,
                        LastName = m.LastName,
                        Telefono = m.Telefono,
                        CanAcces = m.CanAcces,
                        Active = m.Active,                        
                    })
                    .Where(m => m.Active == true)
                    .ToListAsync();
                return Ok(membersList);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error inesperado");
                return StatusCode(500, new { code = 500, message = "Error interno al obtener la lista de miembros." });
            }
        }

        [HttpPost(Name = "CreateMember")]
        [EndpointSummary("Crear un nuevo socio")]
        public async Task<IActionResult> CreateMember(MembersDTO m)
        {                        
            try
            {
                var member = new Member
                {
                    Name = m.Name,
                    LastName = m.LastName,
                    Telefono = m.Telefono,
                    Correo = m.Correo,
                    CanAcces = true,
                    Active = true,
                    FechaAlta = DateTime.Now                    
                };
                dbContext.Member.Add(member);
                await dbContext.SaveChangesAsync();
                return CreatedAtAction(nameof(CreateMember), new { id = member.Id }, member);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error inesperado");
                return StatusCode(500, new { message = "Error interno al crear el miembro." });
            }
        }
    }
}
