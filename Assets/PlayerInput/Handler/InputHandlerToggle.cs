using UnityEngine.InputSystem;

namespace PlayerInput.Handler
{
    public class InputHandlerToggle : InputHandlerBool
    {
        protected override void OnActionTriggered(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                actionState = !actionState;
            }
        }
    }
}