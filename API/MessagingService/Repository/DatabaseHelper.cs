using MongoDB.Driver;

namespace MessagingService.Repository
{
    public static class DatabaseHelper
    {
        public static IMongoDatabase GetDatabase()
        {
            // Todo: Move connection string and database name to config

            var client = new MongoClient("mongodb+srv://test:gORnKo6jT9HZ3rHG@cluster0.4h9vt.azure.mongodb.net/test?retryWrites=true&w=majority");
            return client.GetDatabase("test");
        }

        public static IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            var database = GetDatabase();
            var collection = database.GetCollection<T>(collectionName);
            if (collection == null)
            {
                database.CreateCollection("message");
            }

            return collection;
        }

    }
}
