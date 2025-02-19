// See https://aka.ms/new-console-template for more information
using ConsoleAppDevart;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");

var builder = Host.CreateDefaultBuilder();

var host = builder.ConfigureServices(ConfigureServices)
    .Build();


var dbContext = host.Services.GetRequiredService<Db11gContext>();


var gf = await dbContext.TbManMeEquipment.ToListAsync();
var skip = await dbContext.TbManMeEquipment.Skip(20).ToListAsync();
var take = await dbContext.TbManMeEquipment.Take(20).ToListAsync();


Console.WriteLine(gf.Count);

static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
{

    services.AddDbContext<Db11gContext>(options =>
    {
        options.UseOracle(Db11gContext.ConnectionStringDefault);


    });
}


