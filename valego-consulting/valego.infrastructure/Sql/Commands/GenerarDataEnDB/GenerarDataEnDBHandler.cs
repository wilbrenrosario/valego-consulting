using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using valego.application;
using valego.core.Models;

namespace valego.infrastructure.Sql.Commands.GenerarDataEnDB
{
    public class GenerarDataEnDBHandler : IRequestHandler<GenerarDataEnDBCommand, IEnumerable<Announcement>>
    {
        private readonly IApplicationDbContext _context;
        private string URL_BASE = "https://www.bitmex.com/api/v1/";

        public GenerarDataEnDBHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Announcement>> Handle(GenerarDataEnDBCommand request, CancellationToken cancellationToken)
        {
            var client = new HttpClient();
            var result = await client.GetAsync($"{URL_BASE}announcement");
            var resultString = await result.Content.ReadAsStringAsync();

            var listado = JsonSerializer.Deserialize<List<Announcement>>(resultString, new 
                JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            await _context.Announcement.ExecuteDeleteAsync();
            await _context.Announcement.AddRangeAsync(listado);
            await _context.SaveChangesAsync();

            return listado;
        }
    }
}
