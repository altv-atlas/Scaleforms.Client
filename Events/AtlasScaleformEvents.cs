using AltV.Atlas.Scaleforms.Shared.Models;
namespace AltV.Atlas.Scaleforms.Client.Events;

/// <summary>
/// Class that receives and emits events that occur within scaleform module
/// </summary>
public class AtlasScaleformEvents
{
    #region DrawIndustrialMenuScaleform

    /// <summary>
    /// Delegate
    /// </summary>
    public delegate void PlayerDrawIndustrialMenuScaleformDelegate( List<IndustrialButton> industrialButtons );

    /// <summary>
    /// Triggers when an industrial menu was drawn
    /// </summary>
    public event PlayerDrawIndustrialMenuScaleformDelegate? OnPlayerDrawIndustrialMenuScaleform;

    /// <summary>
    /// Event that triggers when an industrial menu was drawn
    /// </summary>
    /// <param name="industrialButtons">The buttons to draw</param>
    public void PlayerDrawIndustrialMenuScaleform( List<IndustrialButton> industrialButtons )
    {
        OnPlayerDrawIndustrialMenuScaleform?.Invoke( industrialButtons );
    }

    #endregion

    #region HideIndustrialMenuScaleform

    /// <summary>
    /// Delegate
    /// </summary>
    public delegate void PlayerHideIndustrialMenuScaleformDelegate( );

    /// <summary>
    /// Triggers when an industrial menu was hidden
    /// </summary>
    public event PlayerHideIndustrialMenuScaleformDelegate? OnPlayerHideIndustrialMenuScaleform;

    /// <summary>
    /// Event that triggers when an industrial menu was hidden
    /// </summary>
    public void PlayerHideIndustrialMenuScaleform( )
    {
        OnPlayerHideIndustrialMenuScaleform?.Invoke( );
    }

    #endregion
}