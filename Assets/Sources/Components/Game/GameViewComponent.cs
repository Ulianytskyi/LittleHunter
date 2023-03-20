using Entitas;
using UnityEngine;

namespace Sources.Components.Game
{
    /// <summary>
    /// Stores the GameObject and the Transform associated the the entity.
    /// </summary>
    [Game]
    public sealed class GameViewComponent : IComponent
    {
        public GameObject gameObject;
        public Transform transform;
    }
}
