namespace MongoDBData.Service
{
    using System.Threading.Tasks;
    using Entities;
    using Interfaces;
    using MongoDB.Bson;
    using MongoDB.Driver;

    public class TeamsService : EntityService<Team>, ITeamService
    {

        public void AddTeam(Team entity)
        {
            Create(entity);
        }

        public Task<Team> GetTemaById(string id)
        {
            return MongoConnectionHandler.MongoCollection.Find(x => x.Id == new ObjectId(id)).FirstAsync();
        }

    }
}
