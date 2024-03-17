using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    [Header("Base settings")]
    public int health = 3;
    public int score;
    public int taskScore = 3;

    public int costGun = 3;

    [Header("Points move level")]
    [SerializeField] private Transform[] points;

    [Header("Enemies")]
    [SerializeField] private List<Transform> enemies;

    [Header("Guns")]
    [SerializeField] private List<Transform> guns;

    [Header("Managers")]
    public SpawnComponent spawnComponent;

    [Header("Events")]
    public UnityEvent<List<Transform>> createNewEnemy;

    public void AddHealth(int addHealth)
    {
        health += addHealth;
    }

    public void AddScore(int addScore)
    {
        score += addScore;
    }

    public int GetScore()
    {
        return score;    
    }
    
    public int GetTaskScore()
    {
        return taskScore;
    }
    public void LoadLevel(string namelevel)
    {
        SceneManager.LoadScene(namelevel);
    }

    public void LevelManagerWithScore()
    {
        if (score == taskScore)
        {
            LoadLevel("LevelList");
        }
    }

    public void SpawnNewEnemy(GameObject newEnemy)
    {
        EnemyManager enemyManager = newEnemy.GetComponent<EnemyManager>();

        if (enemyManager != null )
        {
            enemyManager.AddPoints(points);
            enemyManager.deathEvent.AddListener(DeathEnemy);
            enemyManager.finalPointEvent.AddListener(FinalPointEnemy);

            enemies.Add(enemyManager.transform);

            createNewEnemy.Invoke(enemies);
        }
    }

    private void DeathEnemy(EnemyManager enemyManager)
    {
        enemies.Remove(enemyManager.transform);
        AddScore(1);
    }

    private void FinalPointEnemy(EnemyManager enemyManager)
    {
        enemies.Remove(enemyManager.transform);
        AddHealth(-1);
    }

    public void AddGun(GunManager gunManager)
    {
        if (guns.Contains(gunManager.transform) == false)
        {
            guns.Add(gunManager.transform);

            createNewEnemy.AddListener(gunManager.SetTarget);
        }
    }
}
    