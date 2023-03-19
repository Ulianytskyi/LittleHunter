using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Sources.Components.Network.Launcher
{
    /// <summary>
    /// Flag whether the connection was successful!
    /// </summary>
    [Network, Unique]
    public sealed class ConnectionSuccessfulComponent : IComponent
    {
        
    }
}
