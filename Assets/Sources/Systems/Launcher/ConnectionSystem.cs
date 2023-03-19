using System.Collections.Generic;
using Entitas;
using Photon.Pun;
using Sources.MonoBehaviours;
using UnityEngine;

namespace Sources.Systems.Launcher
{
    /// <summary>
    /// System that managed the initial connection, and room creation.
    /// </summary>
    public class ConnectionSystem : ReactiveSystem<NetworkEntity>, ICleanupSystem
    {
        private readonly NetworkContext _networkContext;
        private readonly GameContext _gameContext;
        private readonly SettignsContext _settingsContext;
        private readonly LauncherSystem _callbackCaller;

        public ConnectionSystem(Contexts context, LauncherSystem callbackCaller) : base(context.network)
        {
            _networkContext = context.network;
            _gameContext = context.game;
            _settingsContext = context.settigns;
            _callbackCaller = callbackCaller;
            _callbackCaller.onConnectedToMaster += OnConnectedToMaster;
            _callbackCaller.onPhotonRandomJoinFailed += OnPhotonRandomJoinFailed;
            _callbackCaller.onJoinedRoom += OnJoinedRoom;
        }

        protected override ICollector<NetworkEntity> GetTrigger(IContext<NetworkEntity> context)
        {
            return context.CreateCollector((NetworkMatcher.SourcesComponentsNetworkLauncherShouldConnect));
        }

        protected override bool Filter(NetworkEntity entity)
        {
            return entity == _networkContext.sourcesComponentsNetworkLauncherShouldConnectEntity;
        }

        protected override void Execute(List<NetworkEntity> entities)
        {
            if (_gameContext.hasSourcesComponentsNetworkLauncherPlayerName)
            {
                if (PhotonNetwork.IsConnected)
                {
                    PhotonNetwork.JoinRandomRoom();
                }
                else
                {
                    PhotonNetwork.ConnectUsingSettings();
                }

                _networkContext.isSourcesComponentsNetworkLauncherPendingConnection = true;
            }
        }

        public void Cleanup()
        {
            _networkContext.isSourcesComponentsNetworkLauncherPendingConnection = false;
        }
        
        private void OnConnectedToMaster()
        {
            PhotonNetwork.JoinRandomRoom();
        }

        private void OnPhotonRandomJoinFailed(object[] obj)
        {
            PhotonNetwork.CreateRoom("SandboxRoom", new Photon.Realtime.RoomOptions()
            {
                MaxPlayers = (byte) _settingsContext.sourcesComponentsSettingsGameSettings.value.NetworkConfig.maxNumberOfPlayers
                
            }, null);
        }
        
        private void OnJoinedRoom()
        {
            Debug.Log("Room Joined: " + PhotonNetwork.CurrentRoom.Name);
            _networkContext.isSourcesComponentsNetworkLauncherPendingConnection = false;
            _networkContext.isSourcesComponentsNetworkLauncherConnectionSuccessful = true;
        }
    }
}
