using UnityEngine;

namespace PlayerInput.Transformers
{
    [CreateAssetMenu(menuName = "PlayerInput/Transformer/BasicTransformer")]
    public class BasicTransformer : Transformer2D
    {
        [SerializeField] protected float moveSpeed = 10.0f;
        
        public override Vector2 Transform(Vector2 movement, float deltaTime)
        {
            return new Vector2(movement.x, movement.y) * (moveSpeed * deltaTime);
        }
    }
}
