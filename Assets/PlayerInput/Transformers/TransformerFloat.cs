using UnityEngine;

namespace PlayerInput.Transformers
{
    public abstract class TransformerFloat : ScriptableObject
    {
        public abstract float Transform(float value, float deltaTime);
    }
}