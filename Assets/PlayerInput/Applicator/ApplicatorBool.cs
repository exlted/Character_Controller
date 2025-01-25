using UnityEngine;

namespace PlayerInput.Applicator
{
    public abstract class ApplicatorBool : ScriptableObject
    {
        public abstract void Apply(MonoBehaviour context, bool input);
    }
}