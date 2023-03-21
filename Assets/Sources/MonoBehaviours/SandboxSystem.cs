using System;
using UnityEngine;
using Entitas;
using System.Collections.Generic;
using Photon.Pun;
using Sources.Systems.Game;

namespace Sources.MonoBehaviours
{
    public sealed class SandboxSystem : MonoBehaviourPunCallbacks
    {
        [SerializeField] private List<Transform> spawnPoints;
        
        private Entitas.Systems _systems;
        private Contexts _contexts;

        private Entitas.Systems _physicSystems;
        
        private void Awake()
        {
            _contexts = Contexts.sharedInstance;
            _systems = new Feature("Game Systems");
            _physicSystems = new Feature("Physics Systems");
            
            _systems.Add(new CreateSpawnPointSystem(_contexts, spawnPoints));
            _systems.Add(new CreateLocalPlayerSystem(_contexts));

            _physicSystems.Add(new MovePlayerSystem(_contexts));
            //_physicSystems.Add(new RotatePlayerSystem(_contexts));
        }

        private void Start()
        {
            _contexts.network.isSourcesComponentsNetworkLauncherPendingConnection = false;
            _systems.Initialize();
            _physicSystems.Initialize();
        }

        private void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }

        private void FixedUpdate()
        {
            _physicSystems.Execute();
            _physicSystems.Cleanup();
        }
    }
}
