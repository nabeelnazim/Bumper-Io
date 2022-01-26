﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBound : MonoBehaviour
{
    private GameObject enemy;
    private GameObject player;
    public bool isdead = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        enemy = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < 0)
        {
            Destroy(gameObject);
            isdead = true;
            Debug.Log("Enemy Destroyed");
        }
        
    }
}
