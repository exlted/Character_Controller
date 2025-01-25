using PlayerInput.Applicator;
using PlayerInput.Handler;
using PlayerInput.Transformers;
using UnityEngine;
using UnityEngine.InputSystem;

namespace PlayerInput.Wrapper
{
    [CreateAssetMenu(menuName = "PlayerInput/Wrapper/Vector2")]
    public class TwoDVectorWrapper : InputWrapper
    {
        public InputHandler2D handler2D;
        public Transformer2D transformer2D;
        public Applicator2D applicator2D;
        
        public override void OnStart(InputActionMap actionMap)
        {
            handler2D.HookControl(actionMap);
        }

        public override void OnUpdate(MonoBehaviour context, float deltaTime)
        {
            applicator2D.Apply(context, transformer2D.Transform(handler2D.lastAction, deltaTime));
        }
    }
}