﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool EnnemyAlive;
    // Start is called before the first frame update
    void Start()
    {
        EnnemyAlive = true;
    }

    // Update is called once per frame
    /*
    void Update()
    {
        if(EnnemyAlive == true)
        {

        }
    }
    */
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" && EnnemyAlive == true)
        {
            collision.gameObject.GetComponent<PlayerController>().PlayerHealthDamage(1);
        }
    }
}
