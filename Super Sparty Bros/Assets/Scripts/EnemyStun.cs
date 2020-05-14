using UnityEngine;
using System.Collections;

public class EnemyStun : MonoBehaviour {

	// if Player hits the stun point of the enemy, then call Stunned on the enemy
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player" && GameManager.gm.isBig)
		{
			other.gameObject.GetComponent<CharacterController2D>().EnemyBounce();
			other.gameObject.GetComponent<CharacterController2D>().CollectCoin(2);
			Destroy(this.gameObject.transform.parent.gameObject);
		}
		else if (other.gameObject.tag == "Player")
		{
			// tell the enemy to be stunned
			this.GetComponentInParent<Enemy>().Stunned();

			// make player bounce off the enemy
			other.gameObject.GetComponent<CharacterController2D>().EnemyBounce();
		}
	}
}
