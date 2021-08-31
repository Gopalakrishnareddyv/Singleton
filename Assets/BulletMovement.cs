using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    float speed = 10f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = -Vector3.right * speed;
        //transform.Translate(-Vector3.right * speed);
    }
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enterd");
            BulletPool.Singleton.RemoveBullet(this.gameObject);
            BulletPool.Singleton.RemoveEnemy(other.gameObject);
        }
    }
    
}
