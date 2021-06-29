using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployObstackle : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float respawnTime = 50.0f;
    private Vector2 screenBounds;
    public Transform[] spawnPoints;
  
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }
    private void spawnEnemy()
    {
        //GameObject a = Instantiate(asteroidPrefab[a]) as GameObject;
        //a.transform.position = new Vector2(screenBounds.x*15, Random.Range(1.9f, -2f));


        int spawnPointsİndex = Random.Range(0, spawnPoints.Length);


        Instantiate(asteroidPrefab,spawnPoints[spawnPointsİndex].position, spawnPoints[spawnPointsİndex].rotation);


    }
    IEnumerator asteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
