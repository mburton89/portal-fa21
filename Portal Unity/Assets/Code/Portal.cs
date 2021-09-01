using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using StarterAssets;
using UnityStandardAssets;
using UnityStandardAssets.Characters.FirstPerson;

public class Portal : MonoBehaviour
{
    public Portal linkedPortal;
    public bool isActive = true;

    private void OnTriggerEnter(Collider other)
    {
        if (isActive)
        {
            isActive = false;
            linkedPortal.isActive = false;
            TeleportObject(other.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isActive = true;
    }

    void TeleportObject(Transform objectTransform)
    {
        objectTransform.position = linkedPortal.transform.position;
    }
}
