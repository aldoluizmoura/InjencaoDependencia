using Microsoft.AspNetCore.Mvc;

namespace Injenção_de_Dependecia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IOperacao _operacao;
        //private readonly IServiceProvider _provider;
        public WeatherForecastController(IOperacao operacao)
        {        
            _operacao = operacao;            
        }    
        
        [HttpGet("FromConstrutor")]
        public IActionResult Construtor()
        {
            return Ok(_operacao.Id);
        }

        //[HttpGet("anotacao")]
        //public IActionResult Anotacao([FromServices] IOperacao operacao)
        //{
        //    return Ok(operacao.Id);
        //}

        //[HttpGet("provider")]
        //public IActionResult Provider()
        //{
        //    return Ok(_provider.GetRequiredService<IOperacao>());
        //}
    }
}