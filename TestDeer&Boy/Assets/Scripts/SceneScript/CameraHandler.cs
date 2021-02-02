using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    public Transform sceneCameraTr;
    public Transform playerTr;
    
    public float cameraDistance;
    public float verticalOffset;
    
    // Update is called once per frame
    void Update()
    {
        sceneCameraTr.position = playerTr.position.normalized * cameraDistance + Vector3.up*verticalOffset;
        sceneCameraTr.LookAt(playerTr);
    }
}
