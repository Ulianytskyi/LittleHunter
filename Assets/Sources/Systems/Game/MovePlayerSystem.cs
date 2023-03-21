using Entitas;
using UnityEngine;

namespace Sources.Systems.Game
{
    /// <summary>
    /// The system moves the player according to the move inputs,
    /// because we're using a rigidbody, this system has to run in FixedUpdate
    /// </summary>
    public class MovePlayerSystem : IExecuteSystem
    {
        private readonly GameContext _gameContext;
        private readonly InputContext _inputContext;
        private Transform _cameraObject;
        public MovePlayerSystem(Contexts contexts)
        {
            _gameContext = contexts.game;
            _inputContext = contexts.input;
            if (Camera.main != null) _cameraObject = Camera.main.transform;
        }

        public void Execute()
        {
            if (_gameContext.isSourcesComponentsGameLocalPlayer)
            {
                GameEntity localPlayer = _gameContext.sourcesComponentsGameLocalPlayerEntity;
                Vector2 axesValue = _inputContext.sourcesComponentsMoveInputComponents.value;

                Vector3 moveDirection = _cameraObject.forward * axesValue.y;
                moveDirection += _cameraObject.right * axesValue.x;
                moveDirection.Normalize();
                moveDirection.y = 0;
                moveDirection *= localPlayer.sourcesComponentsGameMovementSpeed.value;

                localPlayer.sourcesComponentsGamePhysicView.value.velocity = moveDirection;
            }
        }
    }
}
