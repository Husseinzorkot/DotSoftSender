using DotSoftSender;
using DotSoftSender.Data;
using DotSoftSender.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DotSoftSender;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var services = new ServiceCollection();

        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(
                "Host=localhost;Port=5432;Database=dotsoft_sender;Username=postgres;Password=P@ssw0rd"));

        services.AddScoped<Form1>();
        services.AddScoped<frmSender>();
        using var serviceProvider = services.BuildServiceProvider();
        using var scope = serviceProvider.CreateScope();

        var form = scope.ServiceProvider.GetRequiredService<Form1>();

        Application.Run(form);
    }
}