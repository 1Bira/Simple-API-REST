using ApplicationCore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatoController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<Candidato>> Post(Candidato user)
        {            
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<ActionResult<Candidato>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
