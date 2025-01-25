using UnityEngine;

namespace PlayerInput.Applicator
{
    public abstract class ApplicatorFloat : ScriptableObject
    {
        public abstract void Apply(MonoBehaviour context, float input);
    }
}