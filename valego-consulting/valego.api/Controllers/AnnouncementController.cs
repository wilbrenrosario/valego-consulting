using MediatR;
using Microsoft.AspNetCore.Mvc;
using valego.core.Models;
using valego.infrastructure.Sql.Commands.GenerarDataEnDB;
using valego.infrastructure.Sql.Querys.ObtenerData;

namespace valego.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        private IMediator mediator;
        public AnnouncementController(IMediator mediator_) {
        
            mediator = mediator_;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Announcement>>> GenerarDataEnDB()
        {
            var lista = await mediator.Send(new GenerarDataEnDBCommand());
            return (List<Announcement>)lista;
        }

        [HttpGet("obtenerdatadb")]
        public async Task<ActionResult<IEnumerable<Announcement>>> ObtenerDataDB()
        {
            var lista = await mediator.Send(new ObtenerDataCommand());
            return (List<Announcement>)lista;
        }
    }
}
