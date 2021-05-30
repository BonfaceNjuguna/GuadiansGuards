using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipwrap : MonoBehaviour
{

    float leftConstrain = Screen.width;
    float rightConstrain = Screen.width;
    float topConstrain = Screen.height;
    float bottomConstrain = Screen.height;
    float buffer = 1.0f;
    Camera cam;
    float distanceZ;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        distanceZ = Mathf.Abs(cam.transform.position.z + transform.position.z);
        leftConstrain = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, distanceZ)).x;
        rightConstrain = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, distanceZ)).x;
        topConstrain = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, distanceZ)).y;
        bottomConstrain = cam.ScreenToWorldPoint(new Vector3(Screen.height, 0.0f, distanceZ)).y;
    }


    private void screenWrap()
    {
        //check left position
        if (transform.position.x < leftConstrain - buffer)
        {
            transform.position = new Vector3(rightConstrain - 0.10f, transform.position.y, transform.position.z);
        }

        //check right position
        if (transform.position.x > rightConstrain)
        {
            transform.position = new Vector3(rightConstrain, transform.position.y, transform.position.z);
        }

        //check bottom position
        if (transform.position.y < bottomConstrain - buffer)
        {
            transform.position = new Vector3(transform.position.x, topConstrain + buffer, transform.position.z);
        }

        //check top position
        if (transform.position.y < topConstrain + buffer)
        {
            transform.position = new Vector3(transform.position.x, bottomConstrain - buffer, transform.position.z);
        }
    }
}
