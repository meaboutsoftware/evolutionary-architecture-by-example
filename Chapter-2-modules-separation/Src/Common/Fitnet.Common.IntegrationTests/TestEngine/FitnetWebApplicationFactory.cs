namespace EvolutionaryArchitecture.Fitnet.Common.IntegrationTests.TestEngine;

public class FitnetWebApplicationFactory<T> : WebApplicationFactory<T> where T : class
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureAppConfiguration((_, configBuilder) =>
        {
            var settingsPath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "appsettings.IntegrationTests.json");

            configBuilder.AddJsonFile(settingsPath);
        });
    }
}