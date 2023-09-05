using MediatR;
using valego.application;
using valego.core.Models;

namespace valego.infrastructure.Sql.Querys.ObtenerData
{
    public class ObtenerDataHandler : IRequestHandler<ObtenerDataCommand, IEnumerable<Announcement>>
    {

        private readonly IApplicationDbContext applicationDbContext;

        public ObtenerDataHandler(IApplicationDbContext applicationDbContext_) {
            applicationDbContext = applicationDbContext_;
        }

        public async Task<IEnumerable<Announcement>> Handle(ObtenerDataCommand request, CancellationToken cancellationToken)
        {
            return applicationDbContext.Announcement.ToList();
        }
    }
}
