namespace MongoDBData.Interfaces
{
    using System.Threading.Tasks;

    public interface IEntitySerice<T> where T : IMongoEntity
    {
        void Create(T entity);

        void Update(T entity);

        void Delete(string id);

        T GetById(string id);
    }
}