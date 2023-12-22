using AltV.Atlas.Scaleforms.Shared.Models;
using AltV.Net.Client.Elements.Interfaces;
namespace AltV.Atlas.Scaleforms.Client.Events;

/// <summary>
/// Class that receives and emits events that occur within the scaleform module
/// </summary>
public class AtlasScaleformEvents
{
    #region DrawIndustrialMenuScaleform

    /// <summary>
    /// Delegate
    /// </summary>
    public delegate void PlayerDrawIndustrialMenuScaleformDelegate( IPlayer player, List<IndustrialButton> industrialButtons );

    /// <summary>
    /// Triggers when an industrial menu was drawn
    /// </summary>
    public event PlayerDrawIndustrialMenuScaleformDelegate? OnPlayerDrawIndustrialMenuScaleform;

    /// <summary>
    /// Event that triggers when an industrial menu was drawn
    /// </summary>
    /// <param name="player">The player who received the menu</param>
    /// <param name="industrialButtons">The buttons to draw</param>
    public void PlayerDrawIndustrialMenuScaleform( IPlayer player, List<IndustrialButton> industrialButtons )
    {
        OnPlayerDrawIndustrialMenuScaleform?.Invoke( player, industrialButtons );
    }

    #endregion

    #region HideIndustrialMenuScaleform

    /// <summary>
    /// Delegate
    /// </summary>
    public delegate void PlayerHideIndustrialMenuScaleformDelegate( IPlayer player );

    /// <summary>
    /// Triggers when an industrial menu was hidden
    /// </summary>
    public event PlayerHideIndustrialMenuScaleformDelegate? OnPlayerHideIndustrialMenuScaleform;

    /// <summary>
    /// Event that triggers when an industrial menu was hidden
    /// </summary>
    /// <param name="player">The player the menu was hidden for</param>
    public void PlayerHideIndustrialMenuScaleform( IPlayer player )
    {
        OnPlayerHideIndustrialMenuScaleform?.Invoke( player );
    }

    #endregion
}