
using System;
using UnityEngine;
using UnityEngine.Events;

public class CharacterMovementController : MonoBehaviour
{
    //Animation to activate
    public UnityEvent idleAnimationDispatch;
    public UnityEvent walkAnimationDispatch;
    public UnityEvent runAnimationDispatch;
    public UnityEvent jumpInPlaceAnimationDispatch;
    public UnityEvent jumpDistanceAnimationDispatch;
    public UnityEvent turnBackAnimationDispatch;
    
    //Data
    public Rigidbody playerRb;
    public Transform centerMap;
    
    //Movement Setting
    public float walkSpeed;
    public float runSpeed;
    public float radiusRail;
    
    //Current Status
    private int _orientationStatus; 
    private int _walkStatus;
    private int _runStatus;
    private float moveValue;
    private void Awake()
    {
        _walkStatus = 0;
        _runStatus = 0;
        _orientationStatus = 1;
        moveValue = 0;
        playerRb.transform.position = new Vector3(radiusRail,0,0);
    }

    // Update is called once per frame
    public void Walk(int value)
    {
        Debug.Log("walk "+value);
        _walkStatus = value;
        if(_walkStatus!=_orientationStatus && _walkStatus!=0)
        {
            turnBackAnimationDispatch.Invoke();
        }
    }

    public void turnPlayer()
    {
        _orientationStatus *= -1;
    }

    public void Run(int value)
    {
        _runStatus = value;
    }

    public void Jump()
    {
        if (_runStatus!=0  || _walkStatus!=0) jumpDistanceAnimationDispatch.Invoke();
        else jumpInPlaceAnimationDispatch.Invoke();
        
    }

    private void Update()
    {
        if (_walkStatus == 0)
        {
            idleAnimationDispatch.Invoke();
            return;
        }
        
        if(_runStatus==0)walkAnimationDispatch.Invoke();
        else runAnimationDispatch.Invoke();
        var movement = Vector3.forward * _walkStatus;
        moveValue += Time.deltaTime * (walkSpeed+runSpeed*_runStatus)/13 * _walkStatus;

        playerRb.position = new Vector3((float) (Math.Cos(moveValue))*radiusRail,playerRb.position.y,(float) (Math.Sin(moveValue))*radiusRail);
        playerRb.transform.LookAt(centerMap);
        playerRb.transform.Rotate(Vector3.up,90*_orientationStatus);

    }
}
