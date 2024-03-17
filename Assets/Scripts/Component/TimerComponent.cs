using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NewBehaviourScript : MonoBehaviour
{
    public float timeDelay;

    public UnityEvent tickTimeEvent;
   
    private void Start()
    {
        Invoke(nameof(TimeTic), timeDelay);
    }

    private void TimeTic()
    {
        tickTimeEvent?.Invoke();

        Invoke(nameof(TimeTic), timeDelay);
    }
}
