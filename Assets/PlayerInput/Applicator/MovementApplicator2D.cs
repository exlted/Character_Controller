using UnityEngine;

namespace PlayerInput.Applicator
{
    [CreateAssetMenu(menuName = "PlayerInput/Applicator/2D Movement")]
    public class MovementApplicator2D : Applicator2D
    {
        public override void Apply(MonoBehaviour context, Vector2 input)
        {
            context.transform.Translate(input);
        }
    }
}