using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TesteWebMotors.Domain.Domain;
using TesteWebMotors.Domain.Service;
using TesteWebMotors.Entity.Entity;

namespace TesteWebMotors.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnuncioWebMotorsController : ControllerBase
    {
        private readonly AnuncioService<AnuncionWebMotorsModel, AnuncioWebMotorsEntity> _anuncioService;

        public AnuncioWebMotorsController(AnuncioService<AnuncionWebMotorsModel, AnuncioWebMotorsEntity> anuncioService )
        {
            _anuncioService = anuncioService;
        }


        [HttpGet("Listar")]
        public async Task<IActionResult> Listar()
        {
            var resp = await _anuncioService.Listar();
            return Ok(resp);
        }

        [HttpPost("Incluir")]
        public async Task<IActionResult> Incluir([FromBody] AnuncionWebMotorsModel anuncio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (anuncio == null)
                return BadRequest();

            var resp = await _anuncioService.Incluir(anuncio);

            if (resp == null)
            {
                return StatusCode(500, "Erro ao adicionar anuncio!");
            }
            if (resp.ExibicaoMensagem != null)
            {
                return StatusCode(resp.ExibicaoMensagem.StatusCode, resp);
            }

            return Ok(resp);
        }

        [HttpPut("Atualizar")]
        public async Task<IActionResult> Atualizar([FromBody] AnuncionWebMotorsModel anuncio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (anuncio == null)
                return BadRequest();

            var resp = await _anuncioService.Atualizar(anuncio);

            if (resp == null)
            {
                return StatusCode(500, "Erro ao atualizar anuncio!");
            }
            if (resp.ExibicaoMensagem != null)
            {
                return StatusCode(resp.ExibicaoMensagem.StatusCode, resp);
            }

            return Ok(resp);
        }


        [HttpGet("Consultar")]
        public async Task<IActionResult> Consultar(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (id<= 0)
                return BadRequest();

            var resp = await _anuncioService.Selecionar(id);

            if (resp == null)
            {
                return StatusCode(500, "Erro ao atualizar anuncio!");
            }
            if (resp.ExibicaoMensagem != null)
            {
                return StatusCode(resp.ExibicaoMensagem.StatusCode, resp);
            }

            return Ok(resp);
        }



        [HttpDelete("Deletar")]
        public async Task<IActionResult> Deletar(int id)
        {
            if (id<=0)
            {
                return BadRequest();
            }

            var resp = await _anuncioService.Deletar(id);

            if (resp == null)
            {
                return StatusCode(500, "Erro ao atualizar anuncio!");
            }
            if (resp.ExibicaoMensagem != null)
            {
                return StatusCode(resp.ExibicaoMensagem.StatusCode, resp);
            }

            return Ok(resp);
        }
    }
}
