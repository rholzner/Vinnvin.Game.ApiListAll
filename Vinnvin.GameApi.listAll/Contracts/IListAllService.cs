using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vinnvin.GameApi.listAll.Models;

namespace Vinnvin.GameApi.listAll.Contracts
{
    public interface IListAllService
    {
        IEnumerable<Game> ListAll();
    }
}
