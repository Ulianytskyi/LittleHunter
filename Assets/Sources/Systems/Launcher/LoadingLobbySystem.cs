using System.Collections.Generic;
using Entitas;
using Photon.Pun;

namespace Sources.Systems.Launcher
{
    /// <summary>
    /// System that reacts to successful connection to load the next scene
    /// Only runs on the server
    /// </summary>
    public class LoadingLobbySystem : ReactiveSystem<NetworkEntity>
    {
        private readonly NetworkContext _networkContext;
        private readonly SettignsContext _settignsContext;

        public LoadingLobbySystem(Contexts contexts) : base(contexts.network)
        {
            _networkContext = contexts.network;
            _settignsContext = contexts.settigns;
        }

        protected override ICollector<NetworkEntity> GetTrigger(IContext<NetworkEntity> context)
        {
            return context.CreateCollector(NetworkMatcher.SourcesComponentsNetworkLauncherConnectionSuccessful.Added());
        }

        protected override bool Filter(NetworkEntity entity)
        {
            return entity == _networkContext.sourcesComponentsNetworkLauncherConnectionSuccessfulEntity;
        }

        protected override void Execute(List<NetworkEntity> entities)
        {
            PhotonNetwork.LoadLevel(_settignsContext.sourcesComponentsSettingsGameSettings.value.NetworkConfig.roomSceneName);
        }
    }
}
