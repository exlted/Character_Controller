using UnityEngine;
using UnityEngine.InputSystem;

namespace PlayerInput.Handler
{
    public abstract class InputHandler : ScriptableObject
    {
        
        public string actionName;
        
        public void HookControl(InputActionMap actionMap)
        {
            var action = actionMap.FindAction(actionName);
            action.performed += OnActionTriggered;
            action.canceled += OnActionTriggered;
        }

        protected abstract void OnActionTriggered(InputAction.CallbackContext context);
    }
}