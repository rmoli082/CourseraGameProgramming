using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock : MonoBehaviour
{
    Animator _animator;
    Rigidbody2D _rigidbody;

    void Awake()
    {
        _animator = GetComponent<Animator>();
		if (_animator==null) // if Animator is missing
        {
			Debug.LogError("Animator component missing from this gameobject");
            _animator = gameObject.AddComponent<Animator>();
        }

        _rigidbody = GetComponent<Rigidbody2D>();
        if (_rigidbody==null)
        {
			Debug.LogError("Rigidbody2D component missing from this gameobject");
            _rigidbody = gameObject.AddComponent<Rigidbody2D>();
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            _animator.SetTrigger("Shake");
            StartCoroutine (BlockFall());
        }
    }

    IEnumerator BlockFall() {
        yield return new WaitForSeconds(2.0f);
        _rigidbody.isKinematic = false;
        yield return new WaitForSeconds(1.0f);
        Destroy(this.gameObject);
    }
}
