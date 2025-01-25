using System.Collections.Generic;
using UnityEngine;

namespace PlayerInput.Applicator
{
    public class DelegateApplicator : ApplicatorBool
    {
        public delegate void OnApply(bool value);

        private Dictionary<int, OnApply> _onApply;

        private int _nextDelegate;
        
        public override void Apply(MonoBehaviour context, bool input)
        {
            foreach (var onApp in _onApply)
            {
                onApp.Value(input);
            }
        }

        public int RegisterDelegate(OnApply onApply)
        {
            _nextDelegate += 1;
            
            _onApply.Add(_nextDelegate, onApply);
            
            return _nextDelegate;
        }

        public void DeregisterDelegate(int id)
        {
            _onApply.Remove(id);
        }
    }
}