using System;
using Entitas;
using Sources.Features;
using UnityEngine;

namespace Sources
{
    public sealed class Bootstrap : MonoBehaviour
    {
        private GameSystems _gameSystems;

        private void Start()
        {
            Contexts contexts = Contexts.sharedInstance;
            _gameSystems = new GameSystems(contexts);
            _gameSystems.Initialize();
        }

        private void Update()
        {
            _gameSystems.Execute();
            
        }
    }
}