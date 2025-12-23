using CommunityToolkit.Maui;
using MauiIcons.Core;
using MauiIcons.Material;
using Microsoft.Extensions.Logging;
using NeoBeat_Net.Pages.PostLog.Playlist;
using NeoBeat_Net.Pages.PostLog.Profile;
using NeoBeat_Net.Pages.PostLog.Search;
using NeoBeat_Net.Pages.PostLog.Settings;
using NeoBeat_Net.Pages.PreLog.Login;
using NeoBeat_Net.Pages.PreLog.Register;
using UraniumUI;

using NeoBeat_Net.Services.FireBase_Authentication;
using NeoBeat_Net.Services.FireBase_RealTimeDataBase;
using NeoBeat_Net.ViewModels.PostLog.PlayList;
using NeoBeat_Net.ViewModels.PostLog.Profile;
using NeoBeat_Net.ViewModels.PostLog.Search;
using NeoBeat_Net.ViewModels.PostLog.Settings;
using NeoBeat_Net.Pages.PostLog.Settings;
using NeoBeat_Net.Pages.PostLog.Songs;
using NeoBeat_Net.ViewModels.PostLog.Songs;
using NeoBeat_Net.ViewModels.PreLog.Login;
using NeoBeat_Net.ViewModels.PreLog.Register;


namespace NeoBeat_Net;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            // Community toolkit
            .UseMauiCommunityToolkit()
            // Uranium
            .UseUraniumUI()
            .UseUraniumUIMaterial()
            // AathifMahir Icons
            .UseMaterialMauiIcons()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Ubuntu-Bold.ttf", "UbuntuBold");
            });
        // Default size icon
        builder.UseMauiIconsCore(x =>
        {
            x.SetDefaultFontOverride(true);
            x.SetDefaultIconSize(30.0);
        });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        
        
        builder.Services.StartServices();
        builder.Services.StarVmPg();
        
        return builder.Build();
    }
    
    #region MethodsDependencies
    
    #region Services

    private static void StartServices(this IServiceCollection services)
    {
        services.AddTransient<FireBaseAuth>();
        services.AddSingleton<FireBaseRealTime>();
    }

    #endregion

    #region ViewModels/Pages

    private static void StarVmPg(this IServiceCollection services)
    {
        #region PreLogin

        // Login
        services.AddTransient<LoginPageViewModel>();
        services.AddTransient<LoginPage>();
        
        // Register
        services.AddTransient<RegisterPageViewModel>();
        services.AddTransient<RegisterPage>();

        #endregion
        
        #region PostLogin
        
        // Search
        services.AddTransient<SearchPageViewModel>();
        services.AddTransient<SearchPage>();
        
        // PlayList
        services.AddTransient<PlayListPageViewModel>();
        services.AddTransient<PlayListPage>();
        
        // Profile
        services.AddTransient<ProfilePageViewModel>();
        services.AddTransient<ProfilePage>();
        
        // Settings
        services.AddScoped<SettingsPageViewModel>();
        services.AddScoped<SettingsPage>();
        
        // SongsPage
        services.AddTransient<SongPageViewModel>();
        services.AddTransient<SongsPage>();
        #endregion
    }

    #endregion
    
    #endregion
    
    
    
}