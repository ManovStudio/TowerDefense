using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDirection : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public bool useDirection = true;

    void Update()
    {
        if (useDirection)
            transform.position += direction.normalized * speed * Time.deltaTime;
        else
            transform.position += transform.forward * speed * Time.deltaTime;
    }       

}
