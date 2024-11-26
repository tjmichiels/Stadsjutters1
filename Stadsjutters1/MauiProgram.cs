using Microsoft.Extensions.Logging;
using Stadsjutters1.Pages;
using Stadsjutters1.ViewModel;

namespace Stadsjutters1;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        /*
         * Pagina's in de tab bar
         */

        // Home
        builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<HomeViewModel>();

        // Vondsten(kaart)
        builder.Services.AddSingleton<FindingsPage>();

        // Plaats vondst
        builder.Services.AddTransient<PlaceFindingPage>();

        // Chats
        builder.Services.AddSingleton<ChatsPage>();

        // Meldingen
        builder.Services.AddSingleton<NotificationsPage>();


        /*
         * Pagina's in de flyout
         */

        // Profiel
        builder.Services.AddTransient<ProfilePage>();

        // Mijn vondsten
        builder.Services.AddTransient<MyFindingsPage>();

        // Mijn beoordelingen
        builder.Services.AddTransient<MyReviewsPage>();

        // Opgeslagen vondsten
        builder.Services.AddTransient<SavedFindingsPage>();

        // Instellingen
        builder.Services.AddTransient<SettingsPage>();

        // Beheerdersdashboard
        builder.Services.AddTransient<AdminDashboardPage>();

        // Log uit
        builder.Services.AddTransient<LogoutPage>();

        // Log in
        builder.Services.AddTransient<LoginPage>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}