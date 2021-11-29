using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CameraFollow : MonoBehaviour
{
    // camera will follow this object
    public GameObject Target;
    //camera transform
    public Transform camTransform;
    // offset between camera and target
    public Vector3 Offset;
    // change this value to get desired smoothness
    public float SmoothTime = 0.3f;

    //public Rigidbody rigidbody;
    public NavMeshAgent navMeshAgent;
     

    // This value will change at the runtime depending on target movement. Initialize with zero vector.
    private Vector3 velocity = Vector3.zero;

    private void Start()
    {
        //navMeshAgent = GetComponent<NavMeshAgent>();
        Offset = camTransform.position - Target.transform.position;
        //rigidbody = Target.GetComponent<Rigidbody>();
    }

    private void LateUpdate()
    {
        if (navMeshAgent.velocity.magnitude > 0.15f)
        {
            // update position
            Vector3 targetPosition = Target.transform.position + Offset;
            camTransform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, SmoothTime);
            
            // update rotation
            //transform.LookAt(Target.transform);
        }
        
    }
}
