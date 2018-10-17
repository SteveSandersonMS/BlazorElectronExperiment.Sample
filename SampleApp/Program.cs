using Microsoft.AspNetCore.Blazor.Electron;

namespace SampleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BlazorElectron.Run<Startup>("wwwroot/index.html");
        }
    }
}
