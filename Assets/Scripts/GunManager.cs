using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{
    [Header("Main")]
    public float disanseShut = 4;

    [Header("Components")]
    [SerializeField] private LookAt lookAt;
    [SerializeField] private SpawnComponent spawn;
    [SerializeField] private NewBehaviourScript spawnTimer;

    [Header("Managers")]
    public LevelManager levelManager;

    private void Awake()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    private void Start()
    {
        levelManager.AddGun(this);
    }

    public void SetTarget(List<Transform> enemies)
    {
        if (lookAt.target == null)
        {
            foreach (Transform enemy in enemies)
            {
                if (enemy != null)
                {
                    Vector3 directionToTarget = enemy.position - transform.position;

                    if (directionToTarget.magnitude <= disanseShut)
                    {
                        lookAt.target = enemy;
                        break;

                    }
                }
            }
        }
    }
        
        public void TryShut()
        {
            if (lookAt.target != null)
            {
                Vector3 directionToTarget = lookAt.target.position - transform.position;
                if (directionToTarget.magnitude <= disanseShut)
                {
                    spawn.Spawn();
                }
            }
        }
    }


    

