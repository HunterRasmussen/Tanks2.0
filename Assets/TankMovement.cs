using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public CharacterController controller;
    private float speed = 24f;
    private float rotationSpeed = 50.0f;
    private float = curRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotation
        var rot = Input.GetAxisRaw("Mouse X");
        curRotation -= rot;
        Vector3 rotTrans = new Vector3(0, 0, -rot * rotationSpeed * Time.deltaTime);
        transform.Rotate(rotTrans);

        var movement = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(0,0,movement);
        direction.Rotate()
        if(direction.magnitude >= 1)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }



    }
}
