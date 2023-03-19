using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sources.Data
{
    [CreateAssetMenu(fileName = "Assets/_LH/Data/Settings/NewGameSettings", menuName = "LittleHunter/Data/Settings/Game", order = 0)]
    public class GameSettingsData : ScriptableObject
    {
        [Header("Game Settings")]
        public string gameVersion;
        public int buildNumber;

        [Header("Multiplayer Settings"), Space(2f)]
        public NetworkPreset NetworkConfig;
        
        [Serializable]
        public class NetworkPreset
        {
            public int maxNumberOfPlayers;
            public string roomSceneName;
        }
    }
}
