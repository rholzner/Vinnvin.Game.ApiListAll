using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Vinnvin.GameApi.listAll.Contracts;
using Vinnvin.GameApi.listAll.Models;

namespace Vinnvin.GameApi.listAll.Factorys
{
    public class DbHelper : IDbHelper
    {
        private readonly IDbSettings _dbSetting;
        public DbHelper(IDbSettings dbSetting)
        {
            _dbSetting = dbSetting;
        }

        public IEnumerable<Game> GetData()
        {
            var client = new MongoClient(_dbSetting.ConnectionString);
            var database = client.GetDatabase(_dbSetting.DbName);
            var collection = database.GetCollection<Game>(_dbSetting.Collection);
            return collection.Find(x => x.Deleted == false).ToEnumerable();
        }
    }
}
