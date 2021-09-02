using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject enemyPrefab;
    float spawnTime = 1f;
    //[SerializeField] float enemySpeed=0.5f;
    //Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = Vector3.right * enemySpeed;
        //transform.Translate(Vector3.right * enemySpeed);
        var zPosition = Random.Range(-13f, 13f);
        var position = new Vector3(-15f, 1f, zPosition);
        spawnTime -= Time.deltaTime;
        if (spawnTime <= 0)
        {
            GameObject tempEnemy = Instantiate(enemyPrefab, position, Quaternion.identity);
            spawnTime = 1f;
            BulletPool.Singleton.AddEnemy(tempEnemy);
        }
        
    }
}
