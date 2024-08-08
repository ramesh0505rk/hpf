using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    
    public class HpfController : ControllerBase
    {
        [HttpGet("cryptoEg")]
        public IActionResult Get(){
            var htmlPath=Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","index.html");
            var htmlContent=System.IO.File.ReadAllText(htmlPath);
            return Content(htmlContent,"text/html");
        }
        [HttpGet("createVault")]
        public IActionResult Get2(){
            var htmlPath=Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","createVault.html");
            var htmlContent=System.IO.File.ReadAllText(htmlPath);
            return Content(htmlContent,"text/html");
        }
        [HttpGet("paymentForm")]
        public IActionResult Get3(){
            var htmlPath=Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","paymentForm.html");
            var htmlContent=System.IO.File.ReadAllText(htmlPath);
            return Content(htmlContent,"text/html");
        }
    }
}
