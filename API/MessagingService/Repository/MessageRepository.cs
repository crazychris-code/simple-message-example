using MessagingService.Domain;
using MongoDB.Driver;
using System;
using System.Collections.Generic;


namespace MessagingService.Repository
{
    public class MessageRepository
    {
        private const string messageCollectionName = "message";
        private IMongoCollection<Message> _collection;

        public MessageRepository()
        {
            _collection = DatabaseHelper.GetCollection<Message>(messageCollectionName);
        }

        public List<Message> GetAll()
        {
            return _collection.Find(_ => true).ToList();
        }

        public Message Get(Guid id)
        {
            return _collection.Find(_ => _.Id == id).First();
        }

        public void Add(Message message)
        {
            _collection.InsertOne(message);
        }

        public void Save(Message message)
        {
            _collection.ReplaceOne(_ => _.Id == message.Id, message);
        }

        public void Delete(Guid id)
        {
            _collection.DeleteOne(_ => _.Id == id);
        }
    }
}
