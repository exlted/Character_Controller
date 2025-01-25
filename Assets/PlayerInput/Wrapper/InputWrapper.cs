using UnityEngine;
using UnityEngine.InputSystem;

namespace PlayerInput.Wrapper
{
    public abstract class InputWrapper : ScriptableObject
    {
        public abstract void OnStart(InputActionMap actionMap);

        public abstract void OnUpdate(MonoBehaviour context, float deltaTime);
    }
}

/*
    ScriptableObject that holds
        InputWrapper
        InputTransformer
        InputApplicator

    Has a Start and Update function

    In Start:
        Hooks callbacks for the InputWrapper

    In Update:
        Transforms data from InputWrapper via the InputTransformer
            and passes the transformed data to the InputApplicator

    Common PlayerController MonoBehavior holds an array of these InputController ScriptableObjects, calls into each
        Start and Update function for each of them, passing itself in for all of them.
*/