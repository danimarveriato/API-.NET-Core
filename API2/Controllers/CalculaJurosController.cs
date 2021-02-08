using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace API2.Controllers
{
    public class CalculaJurosController : Controller
    {

        [Route("/calculajuros")]
        [HttpGet]
        public async Task<IActionResult> CalculaJuros([FromQuery]decimal ValorInicial, [FromQuery]int Meses)
        {
            decimal juros = 0;
            using (var client = new HttpClient())
            {
                //Busca a Taxa de Juro da API 1
                var response = await client.GetAsync("https://localhost:44317/taxajuros");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    juros = JsonSerializer.Deserialize<Decimal>(result);
                }
            }
            decimal resultado = 0;
            double result1 = 0;
            //Calcula o juro composto dos valores
            result1 = Math.Pow(decimal.ToDouble(ValorInicial + (1 + juros)), Meses);
            //Trunca o resultado e retorna com 2 casas decimais
            resultado = Math.Truncate(100 * (decimal) result1) / 100;

            return Ok(resultado);
        }
    }
}
