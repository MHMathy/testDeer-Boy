using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimationEvent : MonoBehaviour
{
    public Rigidbody playerRB;
    
    public float jumpIntensity;

    public UnityEvent turnEvent;
    
    public void Turn180()
    {
        turnEvent.Invoke();
    }

    public void Jump()
    {
        playerRB.AddForce(Vector3.up*jumpIntensity,ForceMode.Impulse);
    }
}
