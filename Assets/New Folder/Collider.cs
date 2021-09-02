using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            BulletPool.Singleton.RemoveEnemy(other.gameObject);
        }
    }
}
