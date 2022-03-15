using Microsoft.AspNetCore.Mvc;

namespace Injenção_de_Dependecia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       private readonly IOperacao _operacao;
       private readonly IEnumerable<IOperacao> _operacoes;
        public WeatherForecastController(IOperacao operacao, IEnumerable<IOperacao> operacoes)
        {
           _operacao = operacao;
            _operacoes = operacoes;
        }    
        
        [HttpGet("FromConstrutor")]
        public IActionResult Construtor()
        {
            return Ok(new
            {
                Primeiro = _operacoes.FirstOrDefault(x=>x is PrimeiraOperacao)?.Id,
                Segundo = _operacoes.FirstOrDefault(x => x is SegundaOperacao)?.Id,
                Terceiro = _operacoes.FirstOrDefault(x => x is TerceiraOperacao)?.Id
            });
        }
    }
}