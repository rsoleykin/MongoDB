namespace MongoDBData.Service
{
    using System.Threading.Tasks;
    using Antlr.Runtime;
    using MongoDB.Bson;
    using MongoDB.Driver;
    using MongoDBData.Interfaces;
    using System.Linq;
    using System.Linq.Expressions;

    public abstract class EntityService<T> : IEntitySerice<T> where T: IMongoEntity
    {
        protected readonly MongoConnectionHandler<T> MongoConnectionHandler;
        protected EntityService()
        {
            MongoConnectionHandler = new MongoConnectionHandler<T>();
        }

        public async void Create(T entity)
        {
            await MongoConnectionHandler.MongoCollection.InsertOneAsync(entity);

        }

        public void Update(T entity)
        {
            //var result = _mongoConnectionHandler.MongoCollection.UpdateOneAsync(, entity);
        }

        public void Delete(string id)
        {
            throw new System.NotImplementedException();
        }

        public virtual T GetById(string id)
        {
            //return MongoConnectionHandler.MongoCollection.Find(x => x.Id == new ObjectId(id));v
            //return this.MongoConnectionHandler.MongoCollection.Find(x => x.Id == new ObjectId(id)).FirstOrDefaultAsync().Result;
            throw new System.NotImplementedException();
        }
    }
}