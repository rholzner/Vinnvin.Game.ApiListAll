using System.Collections.Generic;
using Vinnvin.GameApi.listAll.Models;

namespace Vinnvin.GameApi.listAll.Contracts
{
    public interface IDbHelper
    {
        IEnumerable<Game> GetData();
    }
}
