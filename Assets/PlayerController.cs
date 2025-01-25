using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using PlayerInput.Wrapper;

public class PlayerController : MonoBehaviour
{
    public InputWrapper[] preControls;
    public InputWrapper[] controls;
    public InputWrapper[] postControls;
    public string actionMapName;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        var actionMap = InputSystem.actions.actionMaps.FirstOrDefault(map => map.name == actionMapName);

        if (actionMap == null)
        {
            Debug.LogWarning("No action map found for " + actionMapName + ". Not hooking up controls.");
            return;
        }
        
        foreach (var control in preControls)
        {
            control.OnStart(actionMap);
        }
        foreach (var control in controls)
        {
            control.OnStart(actionMap);
        }
        foreach (var control in postControls)
        {
            control.OnStart(actionMap);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        foreach (var control in preControls)
        {
            control.OnUpdate(this, Time.deltaTime);
        }
        foreach (var control in controls)
        {
            control.OnUpdate(this, Time.deltaTime);
        }
        foreach (var control in postControls)
        {
            control.OnUpdate(this, Time.deltaTime);
        }
    }
}
