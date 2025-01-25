using UnityEngine;
using UnityEngine.InputSystem;

namespace PlayerInput.Handler
{
    [CreateAssetMenu(menuName = "PlayerInput/Handler/2D Control")]
    public class InputHandler2D : InputHandler
    {
        public Vector2 lastAction { get; private set; } = Vector2.zero;

        protected override void OnActionTriggered(InputAction.CallbackContext context)
        {
            lastAction = context.ReadValue<Vector2>();
        }
    }
}