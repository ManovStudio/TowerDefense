using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MoveComponent : MonoBehaviour
{
    public float speed = 1f;
    public Transform[] points;

    private int movePointNumber = 1;

    public UnityEvent finalPointEvent;

    private void Update()
    {
        Vector3 moveDirection = points[movePointNumber].position - transform.position;
        transform.position = transform.position + moveDirection.normalized * (Time.deltaTime * speed);

        if (moveDirection.magnitude < 0.1f)
        {
            movePointNumber++;

            if (movePointNumber == points.Length)
            {
                movePointNumber = 0;

                finalPointEvent?.Invoke();
            }
        }
    }
}
 

