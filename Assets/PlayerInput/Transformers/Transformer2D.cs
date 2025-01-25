using UnityEngine;

namespace PlayerInput.Transformers
{
    public abstract class Transformer2D : ScriptableObject
    {
        public abstract Vector2 Transform(Vector2 movement, float deltaTime);
    }
}