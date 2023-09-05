using MediatR;
using valego.core.Models;

namespace valego.infrastructure.Sql.Commands.GenerarDataEnDB
{
    public record GenerarDataEnDBCommand : IRequest<IEnumerable<Announcement>>;
}
