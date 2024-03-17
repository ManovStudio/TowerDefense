using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class TriggerComponent : MonoBehaviour
{
    public UnityEvent onTriggerEnterEvent;
    public UnityEvent onTriggerStayEvent;
    public UnityEvent onTriggerExitEvent;

    private void OnTriggerEnter(Collider other)
    {
        onTriggerEnterEvent.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        onTriggerStayEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        onTriggerExitEvent.Invoke();
    }
}