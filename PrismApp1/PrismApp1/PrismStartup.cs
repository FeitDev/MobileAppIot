using PrismApp1.ViewModels;
using PrismApp1.Views;

namespace PrismApp1;

internal static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        builder.RegisterTypes(RegisterTypes)
                .OnAppStart("AppShell");
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<AppShell>();
        containerRegistry.RegisterForNavigation<Dashboard,DashboardViewModel>();
        containerRegistry.RegisterForNavigation<DashboardDetails, DashboardDetailsViewModel>();
        containerRegistry.RegisterForNavigation<Connection, ConnectionViewModel>();

    }
}
