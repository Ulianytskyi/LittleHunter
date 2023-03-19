using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Sources.Components.Network.Launcher
{
    /// <summary>
    /// Stores the Player of the active player
    /// </summary>
    [Game, Unique]
    public sealed class PlayerNameComponent : IComponent
    {
        public string value;
    }
}
