using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExemploAPISCharp.Model;

namespace ExemploAPISCharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet("GetPessoa")]
        public Pessoa GetPessoa()
        {
            var vPessoa = new Pessoa();
            vPessoa.id = 1;
            vPessoa.nome = "josé das couves";
            vPessoa.NumeroCelular = "(18) 98569-7845";

                return vPessoa;
        }
    }
}
