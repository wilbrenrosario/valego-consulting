using MediatR;
using valego.core.Models;

namespace valego.infrastructure.Sql.Commands.FiltrarPorTitulo
{
    public record FiltrarPorTituloCommand (string buscar): IRequest<IEnumerable<Announcement>>;
}
