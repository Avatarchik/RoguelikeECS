﻿using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class AgentConverter : MonoBehaviour, IConvertGameObjectToEntity
{
    public Grid grid;
    public float maxHealth;
    
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        dstManager.AddComponentData(entity, new AgentComponent());
        var worldPos = grid.WorldToCell(transform.position);
        dstManager.AddComponentData(entity, new GridPos()
        {
            Value = new int2(worldPos.x, worldPos.y)
        });


        dstManager.AddComponentData(entity, default(CopyTransformToGameObject));

        dstManager.AddComponentData(entity, new HealthComponent(){health = maxHealth});
        dstManager.AddComponentData(entity, new WanderAIComponent());
    }
}
