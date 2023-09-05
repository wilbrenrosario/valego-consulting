using MediatR;
using valego.application;
using valego.core.Models;

namespace valego.infrastructure.Sql.Commands.FiltrarPorTitulo
{
    public class FiltrarPorTituloHandler : IRequestHandler<FiltrarPorTituloCommand, IEnumerable<Announcement>>
    {
        private readonly IApplicationDbContext _context;
        public FiltrarPorTituloHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Announcement>> Handle(FiltrarPorTituloCommand request, CancellationToken cancellationToken)
        {
            return _context.Announcement.Where(x => x.title.StartsWith(request.buscar)).ToList();
        }
    }
}
