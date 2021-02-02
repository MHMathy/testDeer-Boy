using System;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class WalkEvent : UnityEvent<int> {}

[System.Serializable]
public class RunEvent : UnityEvent<int> {}
public class InputDispatcher : MonoBehaviour
{
    
    

    private CharacterInputController _characterInputController;
    public WalkEvent walkRightEvent;
    public WalkEvent walkLeftEvent;
    public WalkEvent stopWalkEvent;


    public RunEvent runEvent;
    public RunEvent stopRunEvent;
    public UnityEvent jumpEvent;

    private void Awake()
    {
        _characterInputController = new CharacterInputController();

        _characterInputController.CharacterAction.Walk.performed += context => Walk(context.ReadValue<float>());
        _characterInputController.CharacterAction.Run.performed += context => Run(context.ReadValue<float>());
        _characterInputController.CharacterAction.Jump.started += context => Jump();

    }
    
    
    private void OnEnable()
    {
        _characterInputController.CharacterAction.Enable();
    }
    
    private void OnDisable()
    {
        _characterInputController.CharacterAction.Disable();
    }


    void Walk(float value)
    {
        if (value == 0) stopWalkEvent.Invoke(0);
        else
        {
            if (value > 0) walkRightEvent.Invoke(1);
            else walkLeftEvent.Invoke(-1);
        }
    }
    void Run(float value)
    {
        if (value == 0) stopRunEvent.Invoke(0);
        else runEvent.Invoke(1);
    }

    void Jump()
    {
        jumpEvent.Invoke();
    }


}
