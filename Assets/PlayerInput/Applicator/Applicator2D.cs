using UnityEngine;

namespace PlayerInput.Applicator
{
    public abstract class Applicator2D : ScriptableObject
    {
        public abstract void Apply(MonoBehaviour context, Vector2 input);
    }
}