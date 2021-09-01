using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy Data", menuName = "Enemies", order = 1)]
public class EnemyData : ScriptableObject
{
    public enum POWER { LessPower, MorePower }
    [SerializeField] private string enemyName;
    [SerializeField] private POWER power;
    [SerializeField] private int health;

    public string Name { get { return enemyName; } }
    public POWER Power { get { return power; } }
    public int Health { get { return health; } }
}
