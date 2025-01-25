using PlayerInput.Applicator;
using PlayerInput.Handler;
using PlayerInput.Transformers;
using UnityEngine;
using UnityEngine.InputSystem;

namespace PlayerInput.Wrapper
{
    public class FloatWrapper : InputWrapper
    {
        public InputHandlerFloat input;
        public TransformerFloat transformer;
        public ApplicatorFloat applicator;
        
        public override void OnStart(InputActionMap actionMap)
        {
            input.HookControl(actionMap);
        }

        public override void OnUpdate(MonoBehaviour context, float deltaTime)
        {
            applicator.Apply(context, transformer.Transform(input.lastAction, deltaTime));
        }
    }
}