using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyController : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public float gravity = 9.81f;

    public CharacterController myController;
    // Start is called before the first frame update
    void Start()
    {
        myController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //determine z-direction movement
        Vector3 movementZ = Input.GetAxis("Vertical") * Vector3.forward * moveSpeed * Time.deltaTime;
        //determine x-direction movement
        Vector3 movementX = Input.GetAxis("Horizontal") * Vector3.right * moveSpeed * Time.deltaTime;
        //combine movements and convert from local space to world space based on player transform
        Vector3 movement = transform.TransformDirection(movementX + movementZ);
        //apply gravity
        movement.y -= gravity * Time.deltaTime;
        //move player
        myController.Move(movement);
    }
}
