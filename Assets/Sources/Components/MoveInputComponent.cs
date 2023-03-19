using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Sources.Components
{
    [Input, Unique]
    public class MoveInputComponents : IComponent
    {
        public UnityEngine.Vector2 value;
        
    }
}