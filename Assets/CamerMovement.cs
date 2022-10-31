using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerMovement : MonoBehaviour
{
    private float curXCameraRotation = 0.0f;
    private const float maxXCameraRotation = 10;
    private const float minXCameraRotation = -10;
    private float cameraSpeed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
       Cursor.lockState = CursorLockMode.Locked; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        Debug.Log(-curXCameraRotation);
        if(Mathf.Abs(curXCameraRotation) <= maxXCameraRotation)
        {
            var rot = Input.GetAxisRaw("Mouse Y");
            curXCameraRotation += rot;
            if(curXCameraRotation < minXCameraRotation)
            {
                curXCameraRotation = minXCameraRotation;
            }
            else if(curXCameraRotation > maxXCameraRotation)
            {
                curXCameraRotation = maxXCameraRotation;
            }
            Vector3 trans = new Vector3(-rot * Time.deltaTime * cameraSpeed, 0, 0);
            transform.Rotate(trans);

        }
        

    }
}
