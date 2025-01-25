using PlayerInput.Applicator;
using PlayerInput.Handler;
using UnityEngine;
using UnityEngine.InputSystem;

namespace PlayerInput.Wrapper
{
    public class TriggerWrapper : InputWrapper
    {
        public InputHandlerBool input;
        public ApplicatorBool applicator;
        
        public override void OnStart(InputActionMap actionMap)
        {
            input.HookControl(actionMap);
        }

        public override void OnUpdate(MonoBehaviour context, float deltaTime)
        {
            if (input.actionState)
            {
                applicator.Apply(context, true);
            }
        }
    }
}