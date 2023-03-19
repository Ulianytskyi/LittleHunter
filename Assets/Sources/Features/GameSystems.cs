using Sources.Services;
using Sources.Systems;

namespace Sources.Features
{
    public sealed class GameSystems : Feature
    {
        public GameSystems(Contexts contexts)
        {
            Add(new CreateEntitySystem(contexts));
            Add((new EmitInputSystem(contexts, new UnityInputServiceImplementation())));
        }
    }
}