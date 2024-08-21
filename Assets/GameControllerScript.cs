using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    private float timer = 0f;
    private bool gameOver = false;

    void Update()
    {
        if (!gameOver)
        {
            timer += Time.deltaTime;
            Debug.Log("Time: " + timer);
        }
    }

    public void EndGame()
    {
        gameOver = true;
        Debug.Log("Game Over! Final Time: " + timer);
    }
}