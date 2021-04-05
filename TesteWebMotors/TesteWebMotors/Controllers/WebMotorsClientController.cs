using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TesteWebMotors.Domain.Aggregate;

namespace TesteWebMotors.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebMotorsClientController : ControllerBase
    {
        private readonly IWebMotorsClient _webMotorsClient;

        public WebMotorsClientController(IWebMotorsClient webMotorsClient)
        {
            _webMotorsClient = webMotorsClient;
        }


        [HttpGet("ListarMarcas")]
        public async Task<IActionResult> ListarMarcas()
        {
            var resp = await _webMotorsClient.ObterMarcas();
            return Ok(resp);
        }

        [HttpGet("ListarModelos")]
        public async Task<IActionResult> ListarModelos(int id)
        {
            var resp = await _webMotorsClient.ObterModelos(id);
            return Ok(resp);
        }


        [HttpGet("ListarVersoes")]
        public async Task<IActionResult> ListarVersoes(int id)
        {
            var resp = await _webMotorsClient.ObterVersoes(id);
            return Ok(resp);
        }

    }
}
