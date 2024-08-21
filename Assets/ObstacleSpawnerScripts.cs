using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerScripts : MonoBehaviour
{using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{
    public GameObject[] obstacles; // מערך של המכשולים
    public float spawnInterval = 2f;
    public Transform Obstacles;
    public float obstacleSpeed = 5f;

    void Start()
    {
        StartCoroutine(SpawnObstacles());
    }

    IEnumerator SpawnObstacles()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, obstacles.Length);
            GameObject obstacle = Instantiate(obstacles[randomIndex], spawnPoint.position, Quaternion.identity);

            // ודא שהמכשול מכיל Rigidbody2D
            Rigidbody2D rb = obstacle.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = Vector2.left * obstacleSpeed; // תזוזת המכשול שמאלה
            }
            else
            {
                Debug.LogError("Missing Rigidbody2D on obstacle: " + obstacle.name);
            }

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
