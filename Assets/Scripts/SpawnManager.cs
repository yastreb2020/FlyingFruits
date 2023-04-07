using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] fruits;
    private float zRange = 6;
    private float startY = 0;
    public float startDelay = 1.0f;
    public float spawnTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomFruit", startDelay, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnRandomFruit()
    {
        int randomIndex = Random.Range(0, fruits.Length);
        float randomZ = Random.Range(-zRange, zRange);
        Vector3 newPos = new Vector3(fruits[randomIndex].transform.position.x, startY, randomZ);

        Instantiate(fruits[randomIndex], newPos, fruits[randomIndex].transform.rotation);
    }
}
