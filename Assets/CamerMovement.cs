using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerMovement : MonoBehaviour
{
    private float curXCameraRotation = 0.0f;
    private const float maxXCameraRotation = 15;
    private const float minXCameraRotation = -15;
    private float cameraSpeed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
       Cursor.lockState = CursorLockMode.Locked; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
           Cursor.lockState = CursorLockMode.None; 
           Cursor.visible = true;

            Debug.Log("Escape is pressed?");
        }
        else
        {
           Cursor.lockState = CursorLockMode.Locked; 
           Cursor.visible = false;
        }
        
        //Debug.Log(-curXCameraRotation);
        if(Mathf.Abs(curXCameraRotation) <= maxXCameraRotation)
        {
            var vertRot = Input.GetAxisRaw("Mouse Y");
            curXCameraRotation += vertRot;
            if(curXCameraRotation < minXCameraRotation)
            {
                curXCameraRotation = minXCameraRotation;
            }
            else if(curXCameraRotation > maxXCameraRotation)
            {
                curXCameraRotation = maxXCameraRotation;
            }
            Vector3 trans = new Vector3(-vertRot * Time.deltaTime * cameraSpeed, 0, 0);
            transform.Rotate(trans);

        }


        

    }
}
