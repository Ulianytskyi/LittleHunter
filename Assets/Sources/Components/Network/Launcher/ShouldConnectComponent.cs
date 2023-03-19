using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Sources.Components.Network.Launcher
{
    /// <summary>
    /// Should we try to connect to rhe game server?
    /// </summary>
    [Network, Unique]
    public sealed class ShouldConnectComponent : IComponent
    {
        
    }
}
