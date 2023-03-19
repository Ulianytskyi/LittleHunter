using Entitas;
using Sources.Interfaces;
using UnityEngine;

namespace Sources.Systems
{
    public class EmitInputSystem : IInitializeSystem, IExecuteSystem, ITearDownSystem
    {
        InputContext _inputContext;
        IInputService _inputService;
        public EmitInputSystem(Contexts contexts, IInputService inputService)
        {
            _inputContext = contexts.input;
            this._inputService = inputService;
        }

        public void Initialize()
        {
            _inputContext.SetSourcesComponentsMoveInputComponents(Vector2.zero);
            _inputContext.SetSourcesComponentsLookInput(Vector2.zero);
        }

        public void Execute()
        {
            _inputContext.ReplaceSourcesComponentsMoveInputComponents(_inputService.GetMovement);
            _inputContext.ReplaceSourcesComponentsLookInput(_inputService.GetLook);
        }

        public void TearDown()
        {
            _inputService.Dispose();
        }
    }
}
