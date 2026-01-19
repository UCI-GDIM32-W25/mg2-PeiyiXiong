using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float spawnX = 15f;
    public float spawnY = 12.5f;       
    public float minInterval = 0.8f;  
    public float maxInterval = 2.0f;  

    void Start()
    {
        SpawnCoinWithRandomDelay();
    }

    void SpawnCoinWithRandomDelay()
    {
        
        Vector2 spawnPos = new Vector2(spawnX, spawnY);
        Instantiate(coinPrefab, spawnPos, Quaternion.identity);

        float nextSpawn = Random.Range(minInterval, maxInterval);

        Invoke("SpawnCoinWithRandomDelay", nextSpawn);
    }
}
