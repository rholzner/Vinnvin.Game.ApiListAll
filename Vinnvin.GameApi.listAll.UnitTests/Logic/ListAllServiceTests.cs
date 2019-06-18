using Moq;
using System.Collections.Generic;
using System.Linq;
using Vinnvin.GameApi.listAll.Contracts;
using Vinnvin.GameApi.listAll.Logic;
using Vinnvin.GameApi.listAll.Models;
using Xunit;

namespace Vinnvin.GameApi.listAll.UnitTests.Logic
{
    public class ListAllServiceTests
    {
        private readonly IListAllService service;
        private readonly Mock<IDbHelper> dbHelper;
        public ListAllServiceTests()
        {
            var games = new List<Game>()
            {
                new Game(),new Game(),new Game()
            };
            
            dbHelper = new Mock<IDbHelper>();
            dbHelper.Setup(x => x.GetData()).Returns(games);

            service = new ListAllService(dbHelper.Object);
        }

        [Fact]
        public void ListAll_CallsAllMethods()
        {
            var answer = service.ListAll();
            dbHelper.Verify(x => x.GetData(), Times.Once);
            Assert.Equal(3, answer.Count());
        }
    }
}
