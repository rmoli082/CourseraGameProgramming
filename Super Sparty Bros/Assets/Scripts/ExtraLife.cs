using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other) 
   {
       if (other.tag == "Player")
       {
           if (GameManager.gm) 
           {
               GameManager.gm.AddLife();
            }
            Destroy(this.gameObject);
        }
   }
}
