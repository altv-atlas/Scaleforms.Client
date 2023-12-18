using AltV.Atlas.Scaleforms.Client.Events;
using Microsoft.Extensions.DependencyInjection;
namespace AltV.Atlas.Scaleforms.Client;

/// <summary>
/// Entrypoint for atlas scaleform module
/// </summary>
public static class ScaleformModule
{
    /// <summary>
    /// Registers the scaleform module and it's classes/interfaces
    /// </summary>
    /// <param name="serviceCollection">A service collection</param>
    /// <returns>The service collection</returns>
    public static IServiceCollection RegisterScaleformModule( this IServiceCollection serviceCollection )
    {
        Console.WriteLine( "[ATLAS] Scaleform Module Registered!" );
        serviceCollection.AddSingleton<AtlasScaleformEvents>( );
        serviceCollection.AddSingleton<PlayerDrawIndustrialMenuScaleform>( );
        
        return serviceCollection;
    }
    
    /// <summary>
    /// Initializes the scaleform module
    /// </summary>
    /// <param name="serviceProvider">A service provider</param>
    /// <returns></returns>
    public static IServiceProvider InitializeScaleformModule( this IServiceProvider serviceProvider )
    {
        Console.WriteLine( "[ATLAS] Scaleform Module Initialized!" );
        _ = serviceProvider.GetService<PlayerDrawIndustrialMenuScaleform>( );
        return serviceProvider;
    }
}