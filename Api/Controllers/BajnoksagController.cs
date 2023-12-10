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
        public IActionResult Getx(int sorszám)
        {
            Zh3Context context = new Zh3Context();
            var csapat = (from x in context.Csapats
                           where x.CsapatId == sorszám
                           select x.Nev).FirstOrDefault();

            return new JsonResult(csapat);    
        }

        [HttpPost]
        [Route("csapatok/all")]
        public void Post([FromBody] Csapat újCsapat)
        {
            Zh3Context context=new Zh3Context();
            context.Csapats.Add(újCsapat);
            context.SaveChanges();
        }

        [HttpDelete]
        [Route("csapatok/{id}")]
        public void Delete(int id)
        {
            Zh3Context context = new Zh3Context();
            var törlendő = (from x in context.Csapats
                            where x.CsapatId == id
                            select x).FirstOrDefault();
            context.Remove(törlendő);
            context.SaveChanges();
        }
    }
}
