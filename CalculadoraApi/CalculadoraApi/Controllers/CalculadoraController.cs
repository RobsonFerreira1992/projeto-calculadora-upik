using Microsoft.AspNetCore.Mvc;
using CalculatorApi.Models;
using CalculatorCalc.Utils.Extensions;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        [HttpPost("soma")]
        public IActionResult Soma([FromBody] CalculadoraRequest request)
        {
            try
            {
                double result = request.Calculate("+");
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("subtracao")]
        public IActionResult Subtracao([FromBody] CalculadoraRequest request)
        {
            try
            {
                double result = request.Calculate("-");
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("multiplicacao")]
        public IActionResult Multiplicacao([FromBody] CalculadoraRequest request)
        {
            try
            {
                double result = request.Calculate("*");
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("divisao")]
        public IActionResult Divisao([FromBody] CalculadoraRequest request)
        {
            try
            {
                double result = request.Calculate("/");
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("porcentagem")]
        public IActionResult Porcentagem([FromBody] CalculadoraRequest request)
        {
            try
            {
                double result = request.Calculate("%");
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
