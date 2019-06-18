using Vinnvin.GameApi.listAll.Contracts;

namespace Vinnvin.GameApi.listAll.Models
{
    public class DbSettings : IDbSettings
    {
        public string DbName => "vinvinn_masterDb";
        public string Collection => "games";
        public string ConnectionString => "mongodb://localhost:27017";
    }
}
