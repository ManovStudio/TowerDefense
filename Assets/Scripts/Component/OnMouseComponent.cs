using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnMouseComponent : MonoBehaviour
{
    [Header("Events")]
    public UnityEvent onMouseDownEvent;
    public UnityEvent onMouseUpEvent;
    private void OnMouseDown()
    {
        onMouseDownEvent.Invoke();
    }

    private void OnMouseUp()
    {
        onMouseDownEvent.Invoke();
    }
}
