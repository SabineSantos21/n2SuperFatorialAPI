using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;

namespace n2SuperFatorial.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("[controller]")]
    public class SuperFatorialController : ControllerBase
    {
        private readonly ILogger<SuperFatorialController> _logger;

        public SuperFatorialController(ILogger<SuperFatorialController> logger)
        {
            _logger = logger;
        }

        [HttpGet("SuperFatorial/{numero}")]
        public SuperFatorialModel CalcularSuperFatorial(int numero)
        {
            FatorialService fatorialService = new FatorialService();

            var superFatorial = fatorialService.SuperFatorial(numero);

            SuperFatorialModel response = new SuperFatorialModel();
            response.Numero = numero;
            response.SuperFatorial = superFatorial;

            return response;
        }
    }
}