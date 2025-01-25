using UnityEngine.InputSystem;

namespace PlayerInput.Handler
{
    public class InputHandlerButton : InputHandlerBool
    {
        
        protected override void OnActionTriggered(InputAction.CallbackContext context)
        {
            actionState = context.phase == InputActionPhase.Performed;
        }
    }
}