using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lifeCounterLabel;
    [SerializeField] private BallSpawnerStep13 ballSpawner;

    [SerializeField] private GameOverScreen gameOverScreen;

    private int lifes = 3;
    private const int maxLifes = 3;

    private void Awake() 
    {
        Reset();
        gameOverScreen.gameObject.SetActive(false);
    }

    private void UpdateLifeCounter()
    {
        lifeCounterLabel.text = lifes.ToString();
    }

    public void ReduceLife()
    {
        lifes--;
        UpdateLifeCounter();

        if(lifes > 0)
        {
            ballSpawner.Spawn();
        }else
        {
            gameOverScreen.gameObject.SetActive(true);
        }
    }

    public void Reset()
    {
        lifes = maxLifes;
        UpdateLifeCounter();
        ballSpawner.Spawn();
    }
}
