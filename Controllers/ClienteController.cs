using Microsoft.AspNetCore.Mvc;
using MongoDriver.Models;
using MongoDriver.Repository.Cliente;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDriver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepo _repo;
        public ClienteController(IClienteRepo repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        public async Task<List<Cliente>>  Get() {
            return await _repo.Get();
        }

        [HttpPost]
        public async Task<string> Post([FromBody] Cliente cliente )
        {
            return await _repo.Create(cliente);
        }


    }
}
