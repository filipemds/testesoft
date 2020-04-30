using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ShowMeTheCode.Controllers
{
    [ApiController]
    [Route("showmethecode")]

    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet]
        public List<string> RetornaURL()
        {
            List<string> urlCode = new List<string>() { "https://github.com/filipemds/testeapi" };

            return urlCode;
        }
    }
}