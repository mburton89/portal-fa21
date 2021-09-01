using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bluePortal;
    public GameObject orangePortal;
    public GameObject cubePrefab;
    public Transform firingPoint;
    public AudioSource shootSound;
    public AudioSource errorSound;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootPortal(true);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            ShootPortal(false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            ShootCube();
        }
    }

    void ShootPortal(bool isBlue)
    {
        RaycastHit raycastHit;

        if (Physics.Raycast(firingPoint.position, transform.TransformDirection(Vector3.forward), out raycastHit, Mathf.Infinity))
        {
            if (isBlue)
            {
                bluePortal.transform.SetPositionAndRotation(raycastHit.point, Quaternion.FromToRotation(Vector3.forward, raycastHit.normal));
            }
            else
            {
                orangePortal.transform.SetPositionAndRotation(raycastHit.point, Quaternion.FromToRotation(Vector3.forward, raycastHit.normal));
            }
            shootSound.Play();
        }
        else
        {
            errorSound.Play();
        }
    }

    void ShootCube()
    {
        print("shoot cube");
    }

    void PickUpObject()
    {

    }
}
