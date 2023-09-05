using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using valego.core.Models;
using valego.infrastructure.Sql.Commands.FiltrarPorTitulo;
using valego.infrastructure.Sql.Commands.GenerarDataEnDB;
using valego.infrastructure.Sql.Querys.ObtenerData;
using valego.web.mvc.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace valego.web.mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _mediator.Send(new ObtenerDataCommand());
            return View(data);
        }

        public async Task<IActionResult> Update()
        {
            await _mediator.Send(new GenerarDataEnDBCommand());
            var data = await _mediator.Send(new ObtenerDataCommand());
            return RedirectToAction("Index", data);
        }

       public async Task<IActionResult> buscar(string buscar) 
        {
            if (buscar.IsNullOrEmpty())
            {
                var data = await _mediator.Send(new ObtenerDataCommand());
                return RedirectToAction("Index", data);
            }
            else
            {
                var data = await _mediator.Send(new FiltrarPorTituloCommand(buscar));
                return View("Index", data);
            }
          
        }
    }
}