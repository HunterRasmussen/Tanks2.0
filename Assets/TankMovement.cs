using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public CharacterController controller;
    private float speed = 24f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxisRaw("Vertical");
//        Debug.Log("Movemnt:" + movement.ToString()); 
        Vector3 direction = new Vector3(0,0,movement);
        if(direction.magnitude >= 1)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }
    }
}
