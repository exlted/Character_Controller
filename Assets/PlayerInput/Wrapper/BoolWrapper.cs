using PlayerInput.Applicator;
using PlayerInput.Handler;
using PlayerInput.Transformers;
using UnityEngine;
using UnityEngine.InputSystem;

namespace PlayerInput.Wrapper
{
    public class BoolWrapper : InputWrapper
    {
        public InputHandlerBool input;
        public TransformerBool transformer;
        public ApplicatorBool applicator;
        
        public override void OnStart(InputActionMap actionMap)
        {
            input.HookControl(actionMap);
        }

        public override void OnUpdate(MonoBehaviour context, float deltaTime)
        {
            applicator.Apply(context, transformer.Transform(input.actionState, deltaTime));
        }
    }
}