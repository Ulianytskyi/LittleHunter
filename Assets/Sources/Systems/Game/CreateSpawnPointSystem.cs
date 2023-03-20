using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Photon.Pun;

namespace Sources.Systems.Game
{
    /// <summary>
    /// System that selects the right spawning point for the local Player
    /// </summary>
    public sealed class CreateSpawnPointSystem : IInitializeSystem
    {
        private readonly List<Transform> _spawnPoints;
        private readonly GameContext _gameContext;
        
        public CreateSpawnPointSystem(Contexts contexts, List<Transform> spawnPoints)
        {
            _spawnPoints = spawnPoints;
            _gameContext = contexts.game;
        }

        public void Initialize()
        {
            Transform spawner = _spawnPoints[PhotonNetwork.LocalPlayer.ActorNumber - 1];
            _gameContext.ReplaceSourcesComponentsGameSpawnPointComponenct(spawner.position, spawner.rotation);
        }
    }
}
