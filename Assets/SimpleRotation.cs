using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotation : MonoBehaviour
{
    const float StepPerSecond = 200.0f;
    
    private Vector3 RotationPerSecond = new Vector3(0,0,10);

    [Header("Speed Up Key")]
    public KeyCode SpeedUp = KeyCode.None;

    [Header("Speed Down Key")]
    public KeyCode SpeedDown = KeyCode.None;

    //public KeyCo
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        transform.Rotate(RotationPerSecond * Time.deltaTime);

        if (Input.GetKey(SpeedUp)){
            RotationPerSecond = new Vector3(
                RotationPerSecond.x, 
                RotationPerSecond.y, 
                RotationPerSecond.z + (StepPerSecond * Time.deltaTime));
        }
         if (Input.GetKey(SpeedDown)){
            RotationPerSecond = new Vector3(
                RotationPerSecond.x,
                RotationPerSecond.y,
                RotationPerSecond.z - (StepPerSecond * Time.deltaTime));
        }

    }
    
}
    