using FlyoutPageDemo.Views;

namespace FlyoutPageDemo;

internal static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        //builder.RegisterTypes(RegisterTypes)
        //        .OnAppStart("NavigationPage/MainPage");
        builder.RegisterTypes(RegisterTypes)
                .OnAppStart("NavigationPage/FlyoutDemoPage");
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        //containerRegistry.RegisterForNavigation<MainPage>()
        //             .RegisterInstance(SemanticScreenReader.Default);
        containerRegistry.RegisterForNavigation<FlyoutDemoPage>();
    }
}
