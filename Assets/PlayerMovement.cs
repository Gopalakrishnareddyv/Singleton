using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform firePosition;
    public GameObject bulletPrefab;
    [SerializeField] float playerSpeed;
    CharacterController character;
    
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        var move = new Vector3(-v, 0, h);
        character.SimpleMove(move*playerSpeed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
           GameObject temp= Instantiate(bulletPrefab, firePosition.position, Quaternion.identity);
            BulletPool.Singleton.AddBullet(temp);
        }
    }
}
