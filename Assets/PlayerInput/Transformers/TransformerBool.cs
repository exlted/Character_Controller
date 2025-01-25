using UnityEngine;

namespace PlayerInput.Transformers
{
    public abstract class TransformerBool : ScriptableObject
    {
        public abstract bool Transform(bool input, float deltaTime);
    }
}