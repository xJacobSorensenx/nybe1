using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using nybe1.Models;
using nybe1.Services;

namespace nybe1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KundeController : Controller
    {
        private readonly IKundeRepo _repo;
        public KundeController(IKundeRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult> GetKunder() {
            var res = await _repo.HentKunderAsync();
            return Ok(res);
        }

        [HttpPost]
        public async Task<ActionResult> AddKunde([FromBody] Kunde data) {
            if (!ModelState.IsValid){
                return BadRequest("Bad modelstate");
            }else {
                var res = await _repo.AddNyKunde(data);
                return Ok(res);
            }
        }
    }
}