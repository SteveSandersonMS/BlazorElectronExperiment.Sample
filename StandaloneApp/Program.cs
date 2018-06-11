using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.AspNetCore.Blazor.Electron;

namespace StandaloneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Launcher.StartElectronProcess(async () =>
            {
                var window = await Launcher.CreateWindowAsync("./wwwroot/index.html");

                var serviceProvider = new BrowserServiceProvider(configure =>
                {
                    // ... register services here
                });

                new BrowserRenderer(serviceProvider).AddComponent<App>("app");
            });
        }
    }
}
