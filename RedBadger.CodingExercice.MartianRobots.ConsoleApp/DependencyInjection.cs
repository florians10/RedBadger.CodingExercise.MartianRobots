using Microsoft.Extensions.DependencyInjection;
using RedBadger.CodingExercice.MartianRobots.ConsoleApp.Services.Implementation;
using RedBadger.CodingExercice.MartianRobots.ConsoleApp.Services.Strategies.Implementation;
using RedBadger.CodingExercice.MartianRobots.ConsoleApp.Services.Strategies;
using RedBadger.CodingExercice.MartianRobots.ConsoleApp.Services;

namespace RedBadger.CodingExercice.MartianRobots.ConsoleApp
{
    public static class DependencyInjection
    {
        public static void Register(IServiceCollection services) 
        {
            // Strategies
            services.AddKeyedScoped<IMoveStrategy, MoveForwardStrategy>('F');
            services.AddKeyedScoped<IMoveStrategy, MoveLeftStrategy>('L');
            services.AddKeyedScoped<IMoveStrategy, MoveRightStrategy>('R');

            // Services
            services.AddSingleton<IWorldRunnerService, WorldRunnerService>();
            services.AddScoped<IRobotControllerService, RobotControllerService>();
            services.AddScoped<IGridControllerService, GridControllerService>();
        }  
    }
}
