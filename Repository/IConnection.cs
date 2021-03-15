
using MongoDB.Driver;

namespace MongoDriver.Repository
{
    public interface IConnection
    {
        IMongoCollection<T> getCollection<T>(string dataDabseName, string collectionName);
    }
}
