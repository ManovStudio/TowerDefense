using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyComponent : MonoBehaviour
{

    public UnityEvent destroyEvent;
    public void Destroy()
    {
        destroyEvent.Invoke();

        Destroy(gameObject);
    }
}
