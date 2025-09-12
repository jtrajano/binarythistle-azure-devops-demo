using Microsoft.AspNetCore.Mvc.Testing;

namespace SimpleAPI.Test;

public class BaseAPITest : IClassFixture<WebApplicationFactory<SimpleAPI.Program>>, IDisposable
{
    protected HttpClient _client;
    public BaseAPITest(WebApplicationFactory<SimpleAPI.Program> webApp)
    {
        _client = webApp.CreateClient();
    }

    public virtual void Dispose()
    {
        _client?.Dispose();
    }
}