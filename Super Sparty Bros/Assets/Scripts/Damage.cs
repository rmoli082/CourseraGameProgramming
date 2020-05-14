﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<CharacterController2D>().EnemyBounce();
            other.gameObject.GetComponent<CharacterController2D>().ApplyDamage(5);
        }
            
    }
}
