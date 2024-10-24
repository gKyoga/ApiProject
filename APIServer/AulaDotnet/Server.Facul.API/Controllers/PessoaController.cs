using Domain.Entity;
using Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Facul.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoa _pessoa;

        public PessoaController(IPessoa pessoa)
        {
            _pessoa = pessoa;
        }

        [HttpGet]
        public async Task<IActionResult>PegarTodos()
        {
            var pessoas = await _pessoa.buscarTodos();
            return Ok(pessoas);
        }

        [HttpPost]
        [Route("Gravar")]
        public async Task<IActionResult> Gravar([FromBody] Pessoa pessoa)
        {
            var pessoas = await _pessoa.Adicionar(pessoa);
            return Ok(pessoas);
        }
    }
}
