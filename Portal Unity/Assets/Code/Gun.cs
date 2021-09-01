using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject BluePortal;
    public GameObject OrangePortal;
    public Transform FiringPoint;
    public AudioSource ShootSound;
    public AudioSource ErrorSound;

    // Update is called once per frame
    void Update()
    {
        HandleUserInput();
    }

    void ShootPortal(bool isBlue)
    {
        RaycastHit raycastHit;

        //if the raycast hit an object...
        if (Physics.Raycast(FiringPoint.position, transform.TransformDirection(Vector3.forward), out raycastHit, Mathf.Infinity))
        {
            if (isBlue)
            {
                BluePortal.transform.SetPositionAndRotation(raycastHit.point, Quaternion.FromToRotation(Vector3.forward, raycastHit.normal));
                print("blue");
            }
            else
            {
                OrangePortal.transform.SetPositionAndRotation(raycastHit.point, Quaternion.FromToRotation(Vector3.forward, raycastHit.normal));
                print("orange");
            }
            ShootSound.Play();
        }
        //the raycast hit nothing
        else
        {
            ErrorSound.Play();
        }
    }

    void HandleUserInput()
    {
        //Left Click
        if (Input.GetMouseButtonDown(0))
        {
            ShootPortal(true);
        }
        //Right Click
        else if (Input.GetMouseButtonDown(1))
        {
            ShootPortal(false);
        }
    }

    void HidePortals()
    {

    }
}
