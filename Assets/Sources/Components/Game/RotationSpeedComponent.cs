using Entitas;

namespace Sources.Components.Game
{
    /// <summary>
    /// This is the Rotation Speed of the Local Player
    /// </summary>
    [Game]
    public sealed class RotationSpeedComponent : IComponent
    {
        public float value;
    }
}
