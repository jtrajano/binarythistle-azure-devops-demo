using Microsoft.AspNetCore.Mvc.Testing;
using Xunit.Abstractions;

namespace SimpleAPI.Test;

public class UnitTest1 : BaseAPITest, IDisposable
{
    private readonly WebApplicationFactory<SimpleAPI.Program> _webApp;
    private readonly ITestOutputHelper _output;

    public UnitTest1(WebApplicationFactory<SimpleAPI.Program> webApp, ITestOutputHelper output) : base(webApp)
    {
        _webApp = webApp;
        _output = output;
    }

    [Fact]
    public async Task Names_API_Is_Working()
    {
        var result = await _client.GetAsync("/api/names");
        var s = await result.Content.ReadAsStringAsync();
        Assert.True(result.IsSuccessStatusCode);
        Assert.NotNull(s);
    }

    public override void Dispose()
    {
        _webApp?.Dispose();
        base.Dispose();
    }
}
