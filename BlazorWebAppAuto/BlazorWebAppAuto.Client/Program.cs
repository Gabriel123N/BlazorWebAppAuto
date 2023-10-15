using BlazorWebAppAuto.UI;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

internal class Program
{
    private static async global::System.Threading.Tasks.Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        builder.Services.AddSingleton<IRunner, RunnerService>();

        await builder.Build().RunAsync();
    }

    public class RunnerService : IRunner
    {
        public string GetRunningRuntime()
        {
            return "Blazor webassembly";
        }
    }
}