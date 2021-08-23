using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private Rigidbody projectilePrefab;
    [SerializeField]
    private float launchForce = 700f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LaunchProjectile();
        }
    }
    private void LaunchProjectile()
    {
        var projectileInstance = Instantiate(
            projectilePrefab,
            firePoint.position,
            firePoint.rotation);

        projectileInstance.AddForce(firePoint.forward * launchForce);

    }
}
