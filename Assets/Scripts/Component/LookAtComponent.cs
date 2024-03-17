using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform rotate;
    public Transform target;

    private void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 4, Color.black);
        Debug.DrawRay(transform.position, transform.right * 4, Color.black);
        Debug.DrawRay(transform.position, -transform.right * 4, Color.black);
        Debug.DrawRay(transform.position, -transform.forward * 4, Color.black);
        rotate.LookAt(target);   
    }
}
