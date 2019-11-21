using BlazorAppConfTool.Services;
using System.Net.Http;
using Xunit;

namespace ConfToolTests
{
    public class ConferencesServiceTests
    {
        [Fact]
        public void GetConferences_Should_Return_NonEmpty_List()
        {
            var httpClient = new HttpClient();
            var cs = new ConferencesService(httpClient);
            var result = cs.GetConferences().Result;

            //Assert. ...
        }
    }
}
