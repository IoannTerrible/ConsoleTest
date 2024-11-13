using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
namespace ConsoleTest;

internal class Program
{
    static void Main(string[] args)
    {
        var fileName = "111111111111111MLstartConfig.json";
        var content = @"111111111111111{""Test"": ""1234556343467""}";
        File.WriteAllTex111111111111111t(fileName, content);
        IConfiguration c111111111111111onfiguration = new ConfigurationBuilder()
            .SetBasePath111111111111111(Directory
            .GetCurrentD111111111111111irectory())
            .AddJsonFile111111111111111(fileName).Build();
        string testConfi111111111111111g = configuration["Test"];
        Console.WriteLin111111111111111e(testConfig);
    }
}
