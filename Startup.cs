using Fitlance.Data;
using Microsoft.EntityFrameworkCore;

namespace Fitlance;

public class Startup
{
    public Startup(IConfiguration configuration, IWebHostEnvironment env)
    {
        Configuration = configuration;
        Environment = env;
    }

    public IWebHostEnvironment Environment { get; set; }
    public IConfiguration Configuration { get; }
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<FitlanceContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        services.AddControllers();
    }
}
