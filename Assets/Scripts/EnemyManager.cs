using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    public int health = 3;

    [Header("Components")]
    [SerializeField] private MoveComponent moveComponent;
    [SerializeField] private TriggerComponent triggerComponent;
    [SerializeField] private DestroyComponent destroyComponent;
    [SerializeField] private Slider sliderHealth;


    [Header("Event")]
    public UnityEvent<int> changeHealthEvent;
    public UnityEvent<EnemyManager> deathEvent;
    public UnityEvent<EnemyManager> finalPointEvent;

    private void Start()
    {
        moveComponent.finalPointEvent.AddListener(FinalPoint);
    }

    public void AddHealth(int addHealth)
    {
        health += addHealth;

        changeHealthEvent.Invoke(health);

        if (health <= 0)
        {
            deathEvent.Invoke(this);

            destroyComponent.Destroy();
        }
    }

    public void AddPoints(Transform[] points)
    {
        moveComponent.points = points;
    }

    private void FinalPoint()
    {
        finalPointEvent.Invoke(this);

        destroyComponent.Destroy();
    }

    public void changeHealth(int health)
    {
        sliderHealth.value = health;
    }
}
