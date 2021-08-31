using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class BulletPool
{
    private static BulletPool instance;

    private List<GameObject> bullets = new List<GameObject>();
    private List<GameObject> enemies = new List<GameObject>();

    public List<GameObject> bullet
    {
        get
        {
            return bullets;
        }
    }
    public List<GameObject> enemy
    {
        get
        {
            return enemies;
        }
    }
    public static BulletPool Singleton
    {
        get
        {
            if (instance == null)
            {
                instance = new BulletPool();
            }
            return instance;
        }
    }
    public void AddBullet(GameObject gameBullet)
    {
        bullets.Add(gameBullet);
    }
    public void RemoveBullet(GameObject gameBullet)
    {
        var index = bullets.IndexOf(gameBullet);
        bullets.RemoveAt(index);
        GameObject.Destroy(gameBullet);
    }
    public void AddEnemy(GameObject gameEnemy)
    {
        bullets.Add(gameEnemy);
    }
    public void RemoveEnemy(GameObject gameEnemy)
    {
        var index = bullets.IndexOf(gameEnemy);
        bullets.RemoveAt(index);
        GameObject.Destroy(gameEnemy);
    }
}
