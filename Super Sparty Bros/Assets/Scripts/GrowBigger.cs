using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowBigger : MonoBehaviour
{
    public GameObject explosion;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<CharacterController2D>().CollectCoin(5);
            other.GetComponent<CharacterController2D>().GrowBigger();
            if (explosion)
			    {
				    Instantiate(explosion,transform.position,transform.rotation);
			    }
            Destroy(this.gameObject);
        }
    }
}
