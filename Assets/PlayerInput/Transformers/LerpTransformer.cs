using UnityEngine;

namespace PlayerInput.Transformers
{
    [CreateAssetMenu(menuName = "PlayerInput/Transformer/LerpTransformer")]
    public class LerpTransformer : Transformer2D
    {
        [SerializeField] protected float moveSpeed = 10.0f;
        [SerializeField] private float interpolationRate = 0.75f;
        
        private Vector3 _lastTransform;
        
        public override Vector2 Transform(Vector2 movement, float deltaTime)
        {
            var goalTransform = new Vector2(movement.x, movement.y);
            _lastTransform = Vector2.Lerp(_lastTransform, goalTransform, interpolationRate);
            
            return _lastTransform * (moveSpeed * deltaTime);
        }
    }
}
