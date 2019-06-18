using System.Collections.Generic;
using Vinnvin.GameApi.listAll.Contracts;
using Vinnvin.GameApi.listAll.Models;

namespace Vinnvin.GameApi.listAll.Logic
{
    public class ListAllService : IListAllService
    {
        private readonly IDbHelper _dbHelper;
        public ListAllService(IDbHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public IEnumerable<Game> ListAll()
        {
            return _dbHelper.GetData();
        }
    }
}
