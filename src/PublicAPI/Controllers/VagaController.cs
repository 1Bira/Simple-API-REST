using ApplicationCore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class VagaController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<Vaga>> PostVaga(Vaga user)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<ActionResult<Vaga>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
