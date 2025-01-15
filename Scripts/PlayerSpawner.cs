using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public List<GameObject> playerPrefabs;


    void Start()
    {
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
        int playerSpawnIndex = Random.Range(0, playerPrefabs.Count);
        GameObject spawnedPlayer = Instantiate(playerPrefabs[playerSpawnIndex], transform.position, Quaternion.identity);
    }
}