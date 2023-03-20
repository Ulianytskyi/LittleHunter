using Entitas;
using UnityEngine;

namespace Sources.Components.Game
{
    /// <summary>
    /// Stores the Rigidbody associated with the entity.
    /// </summary>
    [Game]
    public sealed class PhysicViewComponent : IComponent
    {
        public Rigidbody value;
    }
}
