using Entitas;

namespace Sources.Components.Game
{
    /// <summary>
    /// The Movement Speed of the Local Player.
    /// </summary>
    [Game]
    public sealed class MovementSpeedComponent : IComponent
    {
        public float value;
        
    }
}
