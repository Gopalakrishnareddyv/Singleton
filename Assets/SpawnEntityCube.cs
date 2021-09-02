using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class SpawnEntityCube : MonoBehaviour,IDeclareReferencedPrefabs,IConvertGameObjectToEntity
{
    public GameObject entityCube;
    public int rows, colums;

    
    public void Convert(Entity entity, EntityManager entityManager, GameObjectConversionSystem conversionSystem)
    {
        var spawnerData = new Spawner
        {
            Prefab = conversionSystem.GetPrimaryEntity(entityCube),
            Erows = rows,
            Ecolumns = colums
        };
        entityManager.AddComponentData(entity, spawnerData);
    }

    public void DeclareReferencedPrefabs(List<GameObject> game)
    {
        game.Add(entityCube);
    }
}
