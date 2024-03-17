using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnComponent : MonoBehaviour
{
    public GameObject spawnObject;
    public Transform spawnPoint;

    public UnityEvent<GameObject> spawnEvent;

    public void Spawn()
    {
        GameObject spawnedObject = Instantiate(spawnObject, spawnPoint.position, spawnPoint.rotation);

        spawnEvent.Invoke(spawnedObject);
    }
}
