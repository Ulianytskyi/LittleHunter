using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Sources.Components.Game
{
    [Game, Unique]
    public sealed class SpawnPointComponenct : IComponent
    {
        public Vector3 position;
        public Quaternion rotation;
    }
}
