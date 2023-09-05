using MediatR;
using valego.core.Models;

namespace valego.infrastructure.Sql.Querys.ObtenerData
{
    public record ObtenerDataCommand : IRequest<IEnumerable<Announcement>>;
}
