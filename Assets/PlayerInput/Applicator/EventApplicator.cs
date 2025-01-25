using System.Data;
using UnityEngine;
using UnityEngine.Events;

namespace PlayerInput.Applicator
{
    public class EventApplicator : ApplicatorBool
    {
        public UnityEvent<bool> unityEvent;
        
        public override void Apply(MonoBehaviour context, bool input)
        {
            if (unityEvent != null)
            {
                unityEvent.Invoke(input);
            }
            else
            {
                throw new DataException("No UnityEvent Defined for EventApplicator");
            }
        }
    }
}