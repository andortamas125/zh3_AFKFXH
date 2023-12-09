using Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BajnoksagController : ControllerBase
    {
        [HttpGet]
        [Route("csapatok/all")]
        public IActionResult Get()
        {
            Zh3Context context = new Zh3Context();
            var csapatok= from x in context.Csapats select x.Nev;

            return Ok(csapatok);
        }

        [HttpGet]
        [Route("csapatok/{sorszám}")]
        public IActionResult Getx(int n)
        {
            Zh3Context context = new Zh3Context();
            var csapat = (from x in context.Csapats
                           where x.CsapatId == n
                           select x.Nev).FirstOrDefault();

            return new JsonResult(csapat);    
        }
    }
}
