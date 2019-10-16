﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public GameObject prefab;
    public float spawnDelay = 1f;
    public int startFoodAvailable = 100;
    public int maxFoodAvailable = 500;

    private float spawnTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < startFoodAvailable; i++)
            Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        // Increase the timer in seconds
        spawnTimer += Time.deltaTime;
        // If timer reaches delay
        if(spawnTimer >= spawnDelay)
        {
            // Spaw a new Food
            Spawn();
            // Reset timer
            spawnTimer = 0f;
        }
    }

    public void Spawn()
    {
        // Generate a new Random position in bounds
        Vector3 randomPos = Game.Instance.GetRandomPosition();
        // Make a new copy of the food prefab at random position and no rotation (Identity
        GameObject foodClone = Instantiate(prefab, randomPos, Quaternion.identity, transform);
    }
}
