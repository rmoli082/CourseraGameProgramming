using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTargetMover : MonoBehaviour
{
    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;

    public enum movementDir {Spin,Horizontal,Vertical};

    public movementDir motionState = movementDir.Horizontal;
    

    // Update is called once per frame
    void Update()
    {
        switch (motionState)
        {
            case movementDir.Horizontal:
                //rotate along the right axis of the object
                gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
                break;
            case movementDir.Vertical:
                //move up and down over time
                gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
                break;
            case movementDir.Spin:
                //rotate around the up axis of the object
                gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
                break;
        }
        
    }
}
