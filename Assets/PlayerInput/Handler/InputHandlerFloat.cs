using UnityEngine.InputSystem;

namespace PlayerInput.Handler
{
    public class InputHandlerFloat : InputHandler
    {
        public float lastAction;
        
        protected override void OnActionTriggered(InputAction.CallbackContext context)
        {
            lastAction = context.ReadValue<float>();
        }
    }
}