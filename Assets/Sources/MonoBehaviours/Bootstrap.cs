using System;
using Entitas;
using Sources.Data;
using Sources.Features;
using UnityEngine;

namespace Sources.MonoBehaviours
{
    public sealed class Bootstrap : MonoBehaviour
    {
        [SerializeField] private string firstSceneName;
        public GameSettingsData gameSettings;
        
        private Contexts _contexts;
        private SettignsContext _settignsContext;
        private GameSystems _gameSystems;

        public static bool IsQuitting { get; private set; }

        private void Awake()
        {
            Application.quitting += delegate { IsQuitting = true; };
            DoAwake();
        }

        private void DoAwake()
        {
            DontDestroyOnLoad(this);
            
            _contexts = Contexts.sharedInstance;
            _settignsContext = _contexts.settigns;
            
            UnityEngine.Random.InitState((int)System.DateTime.Now.Ticks);

            LoadSettings();
            
            _gameSystems = new GameSystems(_contexts);
        }

        private void Start()
        {
            
            _gameSystems.Initialize();
        }

        private void Update()
        {
            _gameSystems.Execute();
            
        }

        private void LoadSettings()
        {
            _settignsContext.SetSourcesComponentsSettingsGameSettings(gameSettings);
        }

        private void OnApplicationQuit()
        {
            _gameSystems.TearDown();
        }
    }
}