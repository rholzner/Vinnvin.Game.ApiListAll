using Newtonsoft.Json.Linq;
using System.Net.Http;
using Vinnvin.GameApi.listAll.Models;
using Xunit;

namespace Vinnvin.GameApi.listAll.ContractTests.Models
{
    public class VocherTests
    {
        private readonly HttpClient httpClient;
        public VocherTests()
        {
            httpClient = new HttpClient();
        }

        [Fact]
        public void Ticket_CheckContract()
        {
            var respons = httpClient.GetAsync("https://localhost:44316/swagger/v1/swagger.json").ConfigureAwait(false).GetAwaiter().GetResult();
            var json = respons.Content.ReadAsStringAsync().ConfigureAwait(false).GetAwaiter().GetResult();
            dynamic data = JObject.Parse(json);
            var props = data.definitions.Vocher.properties;
            var contractTester = new ContractTestHelper();

            contractTester.ContractTest<Vocher>(props);
        }
    }
}
