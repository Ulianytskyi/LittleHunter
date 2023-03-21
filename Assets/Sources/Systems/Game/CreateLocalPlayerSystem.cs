using Entitas;
using Photon.Pun;
using UnityEngine;

namespace Sources.Systems.Game
{
    /// <summary>
    /// System that creates the local Player.
    /// </summary>
    public sealed class CreateLocalPlayerSystem : IInitializeSystem
    {
        private readonly GameContext _gameContext;
        private readonly SettignsContext _settignsContext;
        
        public CreateLocalPlayerSystem(Contexts contexts)
        {
            _gameContext = contexts.game;
            _settignsContext = contexts.settigns;
        }

        public void Initialize()
        {
            _gameContext.isSourcesComponentsGameLocalPlayer = true;

            GameObject playerView = Photon.Pun.PhotonNetwork.Instantiate(
                _settignsContext.sourcesComponentsSettingsGameSettings.value.playerConfig.playerPrefab.name,
                _gameContext.sourcesComponentsGameSpawnPointComponenct.position,
                _gameContext.sourcesComponentsGameSpawnPointComponenct.rotation,0
                );

            GameEntity localPlayer = _gameContext.sourcesComponentsGameLocalPlayerEntity;
            localPlayer.AddSourcesComponentsGameGameView(playerView, playerView.transform);
            localPlayer.AddSourcesComponentsGamePhysicView(playerView.GetComponent<Rigidbody>());
            
            localPlayer.AddSourcesComponentsGameMovementSpeed(_settignsContext.sourcesComponentsSettingsGameSettings.value.playerConfig.movementSpeed);
            localPlayer.AddSourcesComponentsGameRotationSpeed(_settignsContext.sourcesComponentsSettingsGameSettings.value.playerConfig.rotationSpeed);
            
            localPlayer.AddSourcesComponentsGamePhotonView(playerView.GetComponent<Photon.Pun.PhotonView>());
        }
    }
}