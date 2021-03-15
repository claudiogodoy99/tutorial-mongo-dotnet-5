using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDriver.Repository.Cliente
{
    public interface IClienteRepo
    {
        Task<string> Create(Models.Cliente cliente);
        Task<List<Models.Cliente>> Get();
    }
}
