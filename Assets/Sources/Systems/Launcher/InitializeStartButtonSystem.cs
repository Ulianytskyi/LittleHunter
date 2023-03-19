using Entitas;
using UnityEngine.UI;

namespace Sources.Systems.Launcher
{
    /// <summary>
    /// System that connects the connection button to the ECS
    /// </summary>
    public class InitializeStartButtonSystem : IInitializeSystem, ICleanupSystem
    {
        private readonly Button _button;
        private readonly NetworkContext _networkContext;
        
        public InitializeStartButtonSystem (Contexts contexts, Button button)
        {
            _button = button;
            _networkContext = contexts.network;
        }

        public void Initialize()
        {
            _button.onClick.AddListener(OnPressed);
        }

        private void OnPressed()
        {
            _networkContext.isSourcesComponentsNetworkLauncherShouldConnect = true;
        }

        public void Cleanup()
        {
            _networkContext.isSourcesComponentsNetworkLauncherShouldConnect = false;
        }
    }
}

