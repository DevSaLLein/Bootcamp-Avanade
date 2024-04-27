using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return Ok();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return Ok("Error!");
        }

        [HttpGet("ObterObjeto")]
        public IActionResult ObterObjeto()
        {
            Object obj = new Object{};

            return Ok(obj);
        }
    }
}