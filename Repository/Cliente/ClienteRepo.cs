using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDriver.Repository.Cliente
{
    public class ClienteRepo : IClienteRepo
    {
        private readonly IMongoCollection<Models.Cliente> _cliente;

        public ClienteRepo(IConnection connection)
        {
            _cliente = connection.getCollection<Models.Cliente>("youtubio","cliente");
        }


        public async Task<string> Create(Models.Cliente cliente) {
            await _cliente.InsertOneAsync(cliente);
            return cliente.id;
        }

        public async Task<List<Models.Cliente>> Get() => (await _cliente.FindAsync(x => x.id != null)).ToList();

    }
}
