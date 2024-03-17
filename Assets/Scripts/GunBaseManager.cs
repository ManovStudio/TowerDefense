using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBaseManager : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private OnMouseComponent onMouseComponent;
    [SerializeField] private SpawnComponent spawnComponent;
    [SerializeField] private DestroyComponent destroyComponent;

    [Header("Managers")]
    public LevelManager levelManager;

    private void Awake()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }


    public void ClickBase()
    {
        if (levelManager.score > levelManager.costGun)
        {
            spawnComponent.Spawn();
            destroyComponent.Destroy();
        }else
        {
            Debug.Log("You dont have enough score ");
        }
    }
}
