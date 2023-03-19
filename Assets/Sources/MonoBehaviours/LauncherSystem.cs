using System;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Sources.Systems.Launcher;
using TMPro;
using Entitas;

namespace Sources.MonoBehaviours{
    
    public sealed class LauncherSystem : MonoBehaviourPunCallbacks
    {
        [SerializeField] private TMP_InputField PlayerNameField;
        [SerializeField] private Button StartConnectButton;
        [SerializeField] private CanvasGroup loadingScreen;

        public event Action onConnectedToMaster;
        public event Action<object[]> onPhotonRandomJoinFailed;
        public event Action onJoinedRoom;

        private Entitas.Systems _systems;
        private Entitas.Systems _serverSystems;
        private Contexts _contexts;
        private bool serverSystemInitialized = false;

        private void Awake()
        {
            PhotonNetwork.AutomaticallySyncScene = true;
            
            _contexts = Contexts.sharedInstance;
            _systems = new Feature("Launcher Systems");
            _serverSystems = new Feature("Server Systems");

            _systems.Add(new InitializePlayerNameSystem(_contexts, PlayerNameField));
            _systems.Add(new InitializeStartButtonSystem(_contexts, StartConnectButton));
            _systems.Add(new ConnectionSystem(_contexts, this));
            _systems.Add(new ConnectionUISystem(_contexts, loadingScreen));

            _serverSystems.Add(new LoadingLobbySystem(_contexts));
        }

        private void Start()
        {
            _systems.Initialize();
        }

        private void Update()
        {
            if (PhotonNetwork.IsMasterClient)
            {
                if (!serverSystemInitialized)
                {
                    serverSystemInitialized = true;
                    _serverSystems.Initialize();
                }
                _serverSystems.Execute();
                _serverSystems.Cleanup();
            }
            _systems.Execute();
            _systems.Cleanup();
        }

        #region MonoBehaviourPunCallbacks Callbacks
        
        public override void OnConnectedToMaster()
        {
            onConnectedToMaster?.Invoke();
        }

        public override void OnJoinRandomFailed(short returnCode, string message)
        {
            var codeAndMessage = new object[] { returnCode, message };
            onPhotonRandomJoinFailed?.Invoke(codeAndMessage);
        }
        
        public override void OnJoinedRoom()
        {
            onJoinedRoom?.Invoke();
        }

        #endregion

    }
}
