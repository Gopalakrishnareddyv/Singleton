using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject[] prefab;
    public Terrain terrain;
    private void Start()
    {
        SpawningEnemies();
    }
    void SpawningEnemies()
    {
        TerrainData terrainData = terrain.terrainData;
        int spacing = Random.Range(0,50);
        for (int i = 0; i < terrainData.size.x; i+=spacing)
        {
            for (int j = 0; j < terrainData.size.y; j+=spacing)
            {
                Vector3 pos = new Vector3(i, 1, j);
                //pos.y = terrain.SampleHeight(pos);
                int z = Random.Range(0, prefab.Length);
                Instantiate(prefab[z], pos, Quaternion.identity);
            }
        }
    }
}
