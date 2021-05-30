using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "asteroid big" || collision.gameObject.name == "asteroid small")
        {
            Debug.Log("collision");
            Destroy(collision.gameObject);
        }
    }
}
