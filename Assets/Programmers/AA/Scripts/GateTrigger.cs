using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject gate;

    bool isOpened = false;
    
    private void Update()
    {
        if(Input.GetKeyDown("e") && touchingDoor)
        {
            gate.transform.position += new Vector3 (1, 0, 0);
            isOpened = true;
        }
        if(Input.GetKeyDown("e") && isOpened && touchingDoor)
        {
            gate.transform.position -= new Vector3 (1, 0, 0);
            isOpened = false;
        }
        
    }

    private bool touchingDoor = false;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            touchingDoor = true;
        }
    }
}
