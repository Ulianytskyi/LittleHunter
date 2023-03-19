using Sources.Systems;

namespace Sources.Features
{
    public sealed class GameSystems : Feature
    {
        public GameSystems(Contexts contexts)
        {
            Add(new CreateEntitySystem(contexts));
        }
    }
}