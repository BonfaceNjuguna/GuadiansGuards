using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playership : MonoBehaviour
{

    public GameObject Bullet;

    private AudioSource shootBullet;

    void Start()
    {
        shootBullet = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(new Vector3(0, 0, 5) * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(new Vector3(0, 0, -5) * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(new Vector3(0, -90, 0) * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);
        }

        //shooting
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //audio sound shooting
            shootBullet.Play();

            //The Bullet instantiation happens here.
            GameObject Bullet_Handler;
            Bullet_Handler = Instantiate(Bullet) as GameObject;
            Bullet.transform.position = transform.position;
            Bullet.transform.rotation = transform.rotation;
            Destroy(Bullet_Handler, 8.0f);
        }
    }
}
