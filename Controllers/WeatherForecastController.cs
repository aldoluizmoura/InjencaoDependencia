using Microsoft.AspNetCore.Mvc;

namespace Injenção_de_Dependecia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IOperacaoTransiente _operacaoTransiente;
        private readonly IOperacaoSccoped _operacaoSccoped;
        private readonly IOperacaoSingleton _operacaoSingleton;
        public WeatherForecastController(IOperacaoTransiente operacaoTransiente,
                           IOperacaoSccoped operacaoSccoped,
                           IOperacaoSingleton operacaoSingleton)
        {
            _operacaoTransiente = operacaoTransiente;
            _operacaoSccoped = operacaoSccoped;
            _operacaoSingleton = operacaoSingleton;
        }    
        
        [HttpGet("FromConstrutor")]
        public IActionResult Construtor([FromServices] IOperacaoSccoped operacaoSccoped,
                                        [FromServices] IOperacaoTransiente operacaoTransiente,
                                        [FromServices] IOperacaoSingleton operacaoSingleton)
        {
            return Ok(new
            {
                Transient = _operacaoTransiente.Id,
                Sccoped = _operacaoSccoped.Id,
                Singleton = _operacaoSingleton.Id,

                Transient02 = operacaoSccoped.Id,
                Sccoped02 = operacaoTransiente.Id,
                Singleton02 = operacaoSingleton.Id
            });
        }
    }
}