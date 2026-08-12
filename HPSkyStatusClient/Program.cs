using HPSkyStatusClient.Forms;
using HPSkyStatusClient.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Windows.Forms;

namespace HPSkyStatusClient;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        if (!SingleInstanceService.IsFirstInstance())
            return;

        ApplicationConfiguration.Initialize();

        using IHost host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddSingleton<ClientSettingsService>();

                services.AddHttpClient();

                services.AddSingleton<ApiService>();

                services.AddSingleton<StatusService>();

                services.AddSingleton<AuctionWatchService>();

                services.AddSingleton<AuthenticationService>();

                services.AddSingleton<MainForm>();

                services.AddTransient<LoginForm>();

                services.AddTransient<AddAuctionForm>();

                services.AddTransient<AuctionDetailsForm>();

                services.AddSingleton<ClientSettingsApiService>();

                services.AddSingleton<NotificationApiService>();

                services.AddSingleton<NotificationTimeService>();

                services.AddSingleton<ClientPreferencesService>();

                services.AddSingleton<AdminApiService>();

                services.AddSingleton<ItemCacheService>();
            })
            .Build();

        try
        {
            var auth = host.Services.GetRequiredService<AuthenticationService>();

            LoginForm? login = null;

            if (!auth.IsRegistered())
            {
                login = host.Services.GetRequiredService<LoginForm>();

                if (login.ShowDialog() != DialogResult.OK)
                    return;
            }



            var mainForm =
                host.Services.GetRequiredService<MainForm>();

            SingleInstanceService.StartListener(() =>
            {
                if (mainForm.InvokeRequired)
                {
                    mainForm.BeginInvoke(() =>
                    {
                        mainForm.Show();
                        mainForm.WindowState = FormWindowState.Normal;
                        mainForm.BringToFront();
                        mainForm.Activate();
                    });
                }
                else
                {
                    mainForm.Show();
                    mainForm.WindowState = FormWindowState.Normal;
                    mainForm.BringToFront();
                    mainForm.Activate();
                }
            });

            if (login?.AdminAuthenticated == true)
            {
                mainForm.Shown += async (_, _) =>
                {
                    await mainForm.OpenAdminTab();
                };
            }

            Application.Run(mainForm);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.ToString(),
                "HPSkyStatus Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            SingleInstanceService.Dispose();
        }
    }
}