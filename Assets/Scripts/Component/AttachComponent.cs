using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachComponent : MonoBehaviour
{
    public Transform parent;

    public void Attach()
    {
        transform.SetParent(parent);
    }

    public void Detach()
    {
        transform.parent = null;
    }
}