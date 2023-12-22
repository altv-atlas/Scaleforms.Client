using System.Text.Json;
using AltV.Atlas.Scaleforms.Shared;
using AltV.Atlas.Scaleforms.Shared.Models;
using AltV.Atlas.Shared.Extensions;
using AltV.Net.Client;
using AltV.Net.Client.Elements.Interfaces;
namespace AltV.Atlas.Scaleforms.Client.Events;

public class PlayerDrawIndustrialMenuScaleformEvent
{
    private readonly AtlasScaleformEvents _atlasScaleformEvents;
    private uint _everyTick;
    private readonly IPlayer _player = Alt.LocalPlayer;

    public PlayerDrawIndustrialMenuScaleformEvent( AtlasScaleformEvents atlasScaleformEvents )
    {
        _atlasScaleformEvents = atlasScaleformEvents;
        Alt.OnServer<string>( ScaleformConstants.DrawIndustrialMenuEventName, DrawIndustrialMenuScaleform );
        Alt.OnServer( ScaleformConstants.HideIndustrialMenuEventName, HideIndustrialMenuScaleform );
    }

    private void DrawIndustrialMenuScaleform( string buttons )
    {
        var industrialButtons = JsonSerializer.Deserialize<List<IndustrialButton>>( buttons );

        if( industrialButtons.IsNullOrEmpty( ) )
            return;

        _everyTick = AtlasScaleform.DrawIndustrialMenuEveryTick( industrialButtons! );
        _atlasScaleformEvents.PlayerDrawIndustrialMenuScaleform( _player, industrialButtons! );
    }

    private void HideIndustrialMenuScaleform( )
    {
        Alt.ClearEveryTick( _everyTick );
        _atlasScaleformEvents.PlayerHideIndustrialMenuScaleform( _player );
    }
}