using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenwrap : MonoBehaviour
{
    [SerializeField] float screenHeight;
    [SerializeField] float screenWidth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        screenWrap();
    }

    private void screenWrap()
    {
        Vector3 playerPos = transform.position;
        
        //player wrap top and bottom
        if (transform.position.z > screenHeight)
        {
            playerPos.z = -screenHeight;
        }
        if (transform.position.z < -screenHeight)
        {
            playerPos.z = screenHeight;
        }

        //wrap left and right
        if (transform.position.x > screenWidth)
        {
            playerPos.x = -screenWidth;
        }
        if (transform.position.x < -screenWidth)
        {
            playerPos.x = screenWidth;
        }
        transform.position = playerPos;
    }
}
