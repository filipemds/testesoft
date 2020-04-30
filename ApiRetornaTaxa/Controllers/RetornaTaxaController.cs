using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace RetornaTaxa.Controllers
{
    [ApiController]
    [Route("taxaJuros")]

    public class RetornaTaxaController : ControllerBase
    {
        [HttpGet]
        public List<string> RetornaTaxa()
        {
            List<string> taxa = new List<string>() { "1" };

            return taxa;
        }
    }
}