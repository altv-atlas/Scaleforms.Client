using AltV.Atlas.Scaleforms.Shared.Models;
using AltV.Net.Client;
namespace AltV.Atlas.Scaleforms.Client;

/// <summary>
/// The atlas class that provides useful scaleform methods
/// </summary>
public static class AtlasScaleform
{
    /// <summary>
    /// Draws a scaleform with the given industrial buttons
    /// </summary>
    /// <param name="buttons">The buttons to draw</param>
    public static void DrawIndustrialMenu( List<IndustrialButton> buttons )
    {
        var scale = Alt.Natives.RequestScaleformMovie( "INSTRUCTIONAL_BUTTONS" );

        if( Alt.Natives.IsHudHidden( ) )
            return;

        Alt.Natives.BeginScaleformMovieMethod( scale, "CLEAR_ALL" );
        Alt.Natives.EndScaleformMovieMethod( );

        for( var i = 0; i < buttons.Count; i++ )
        {
            var button = buttons[ i ];

            Alt.Natives.BeginScaleformMovieMethod( scale, "SET_DATA_SLOT" );
            Alt.Natives.ScaleformMovieMethodAddParamInt( button.IntParam == -1 ? i : button.IntParam );
            Alt.Natives.ScaleformMovieMethodAddParamTextureNameString( button.InstructionalButtonsString );
            Alt.Natives.ScaleformMovieMethodAddParamTextureNameString( button.DisplayText );
            Alt.Natives.EndScaleformMovieMethod( );
        }
        Alt.Natives.BeginScaleformMovieMethod( scale, "DRAW_INSTRUCTIONAL_BUTTONS" );
        Alt.Natives.ScaleformMovieMethodAddParamInt( 0 );
        Alt.Natives.EndScaleformMovieMethod( );

        Alt.Natives.DrawScaleformMovieFullscreen( scale, 38, 100, 47, 255, 0 );
    }

    /// <summary>
    /// Draws a scaleform with the given industrial buttons every tick
    /// </summary>
    /// <param name="buttons">The buttons to draw</param>
    /// <returns>The every tick id to cancel the drawing</returns>
    public static uint DrawIndustrialMenuEveryTick( List<IndustrialButton> buttons ) => Alt.EveryTick( ( ) => DrawIndustrialMenu( buttons ) );
}