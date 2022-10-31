using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrellMovement : MonoBehaviour
{
    private float curXRotation = 0.0f;
    private float speed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Current Rotation: " + curXRotation);
       if(Mathf.Abs(curXRotation) <= 10)
       {
        var rot = Input.GetAxisRaw("Mouse Y");
        curXRotation+= rot;
        if(curXRotation < -10)
        {
            curXRotation = -10;
        }
        else if(curXRotation > 10)
        {
            curXRotation = 10;
        }
        Vector3 trans = new Vector3(rot * speed  * Time.deltaTime, 0, 0);
        transform.Rotate(trans);
       } 
    }
}
