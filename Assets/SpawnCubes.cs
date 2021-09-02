using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    public GameObject prefab;
    public int rows, columns;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                GameObject temp= Instantiate(prefab);
                Vector3 pos = new Vector3(i,Mathf.PerlinNoise(i*0.2f,j*0.2f)*3, j);
                temp.transform.position = pos;
            }
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
