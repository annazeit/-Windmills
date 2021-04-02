using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is my first script to rotate a windmill.
public class SimpleRotation : MonoBehaviour
{
    const float StepPerSecond = 200.0f;
    
    private float RotationPerSecond = 10.0f;

    [Header("Speed Up Key")]
    public KeyCode SpeedUp = KeyCode.None;

    [Header("Speed Down Key")]
    public KeyCode SpeedDown = KeyCode.None;

    // Update is called once per frame
    void Update(){
        var rotate = new Vector3(0.0f, 0.0f, RotationPerSecond * Time.deltaTime);

        transform.Rotate(rotate);

        if (Input.GetKey(SpeedUp)){
            RotationPerSecond = RotationPerSecond + (StepPerSecond * Time.deltaTime);
        }
         if (Input.GetKey(SpeedDown)){
            RotationPerSecond = RotationPerSecond - (StepPerSecond * Time.deltaTime);
        }

    }
    
}
    