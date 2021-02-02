using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform enemyTr;
    public Transform playerTr;
    public float turnSpeed;
   

    void Update()
    {
        enemyTr.rotation = 
            Quaternion.Lerp(
                enemyTr.rotation, 
                Quaternion.LookRotation(playerTr.position, Vector3.up), 
                Time.deltaTime * turnSpeed);
    }
}
