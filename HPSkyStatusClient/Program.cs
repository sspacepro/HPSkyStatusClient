using HPSkyStatusClient.Configuration;
using HPSkyStatusClient.Forms;
using HPSkyStatusClient.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HPSkyStatusClient;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        using IHost host = Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration(config =>
            {
                config.AddJsonFile("appsettings.json", optional: false);
            })
            .ConfigureServices((context, services) =>
            {
                services.Configure<ApiSettings>(
                    context.Configuration.GetSection("Server"));

                services.AddSingleton<ClientSettingsService>();

                services.AddHttpClient();

                services.AddSingleton<ApiService>();

                services.AddSingleton<StatusService>();

                services.AddSingleton<PlayerWatchService>();

                services.AddSingleton<AuctionWatchService>();

                services.AddSingleton<AuthenticationService>();

                services.AddSingleton<MainForm>();

                services.AddTransient<LoginForm>();

                services.AddTransient<AddAuctionForm>();

                services.AddTransient<AuctionDetailsForm>();

                services.AddSingleton<ApiErrorService>();

                services.AddTransient<AddPlayerForm>();

                services.AddSingleton<ClientSettingsApiService>();

                services.AddSingleton<NotificationApiService>();

                services.AddSingleton<NotificationTimeService>();

                services.AddSingleton<ClientPreferencesService>();

                services.AddSingleton<AdminApiService>();
            })
            .Build();

        var auth = host.Services.GetRequiredService<AuthenticationService>();

        if (!auth.IsRegistered())
        {
            var login = host.Services.GetRequiredService<LoginForm>();

            if (login.ShowDialog() != DialogResult.OK)
                return;
        }

        try
        {
            Application.Run(host.Services.GetRequiredService<MainForm>());
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }
}