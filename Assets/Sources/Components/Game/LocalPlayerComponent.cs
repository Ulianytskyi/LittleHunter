using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Sources.Components.Game
{
    /// <summary>
    /// Flag component that indicates the local player
    /// </summary>
    [Game, Unique]
    public sealed class LocalPlayerComponent : IComponent
    {
        
    }
}
