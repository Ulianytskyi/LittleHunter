using Entitas;
using Entitas.CodeGeneration.Attributes;
using Sources.Data;

namespace Sources.Components.Settings
{
    [Settigns, Unique]
    public sealed class GameSettingsComponent : IComponent
    {
        public GameSettingsData value;
        
    }
}
