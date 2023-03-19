using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Sources.Components.Network.Launcher
{
    /// <summary>
    /// Are we trying to connect to the game server?
    /// </summary>
    [Network, Unique]
    public sealed class PendingConnectionComponent : IComponent
    {
        
    }
}
