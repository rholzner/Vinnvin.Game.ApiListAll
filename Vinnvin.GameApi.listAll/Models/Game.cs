using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Vinnvin.GameApi.listAll.Models
{
    [BsonIgnoreExtraElements]
    public class Game
    {
        public string GameId { get; set; }
        public string Name { get; set; }
        public DateTime DeadLine { get; set; }
        public string Description { get; set; }
        public IEnumerable<Vocher> Vochers { get; set; }
        public bool Deleted { get; set; }
    }
}
