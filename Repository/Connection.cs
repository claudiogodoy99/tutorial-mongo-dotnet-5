using MongoDB.Driver;
using System;

namespace MongoDriver.Repository
{
    public class Connection : IConnection
    {
        private MongoClient client;
        public Connection()
        {
            client = new MongoClient("mongodb+srv://cgodoy:123@cluster0.jfqwo.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
        }


        public IMongoCollection<T> getCollection<T>(string dataDabseName, string collectionName )
        {
            try {
                var database = client.GetDatabase(dataDabseName);
                return database.GetCollection<T>(collectionName);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
