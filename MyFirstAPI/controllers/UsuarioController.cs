using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [HttpGet("ObterObjeto")]
        public IActionResult ObterObjeto()
        {
            Object obj = new Object{};

            return Ok(obj);
        }
    }
}