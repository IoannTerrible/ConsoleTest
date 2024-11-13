using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
namespace ConsoleTest;

internal class Program
{
    static void Main(string[] args)
    {
        var fileName = "MLstartConfig.json";
        var content = @"{""Test"": ""1234556343467""}";
        File.WriteAllText(fileName, content);
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory
            .GetCurrentDirectory())
            .Add(fileName).Build();
        string testConfig = configuration["Test"];
        Console.WriteLine(testConfig);
    }
}
