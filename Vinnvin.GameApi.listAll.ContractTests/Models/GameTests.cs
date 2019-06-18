using Newtonsoft.Json.Linq;
using System.Net.Http;
using Vinnvin.GameApi.listAll.Models;
using Xunit;

namespace Vinnvin.GameApi.listAll.ContractTests.Models
{
    public class GameTests
    {
        private readonly HttpClient httpClient;
        public GameTests()
        {
            httpClient = new HttpClient();
        }

        [Fact]
        public void Game_CheckContract()
        {
            var respons = httpClient.GetAsync("https://localhost:44316/swagger/v1/swagger.json").ConfigureAwait(false).GetAwaiter().GetResult();
            var json = respons.Content.ReadAsStringAsync().ConfigureAwait(false).GetAwaiter().GetResult();
            dynamic data = JObject.Parse(json);
            var props = data.definitions.Game.properties;
            var contractTester = new ContractTestHelper();

            contractTester.ContractTest<Game>(props);
        }
    }
}
