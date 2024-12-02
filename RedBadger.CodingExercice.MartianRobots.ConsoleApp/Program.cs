using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RedBadger.CodingExercice.MartianRobots.ConsoleApp.Services;

namespace RedBadger.CodingExercice.MartianRobots.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IHost host = CreateHostBuilder(args).Build();

            try
            {
                host.Services.GetRequiredService<IWorldRunnerService>().Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static IHostBuilder CreateHostBuilder(string[] strings)
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((_, services) =>
                {
                    DependencyInjection.Register(services);
                });
        }
    }
}
