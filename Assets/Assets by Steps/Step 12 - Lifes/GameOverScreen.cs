using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Step11;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private BounceCounter bounceCounter;
    [SerializeField] private LifeCounter lifeCounter;

    private void OnEnable()
    {
        Time.timeScale = 0;
    }

    private void OnDisable()
    {
        Time.timeScale = 1;
    }

    public void OnPlayButton() 
    {
        gameObject.SetActive(false);
        bounceCounter.Reset();
        lifeCounter.Reset();
    }
}
