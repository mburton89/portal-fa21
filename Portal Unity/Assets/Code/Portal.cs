using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Portal : MonoBehaviour
{
    public Portal linkedPortal;
    public bool isActive;
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (isActive)
        {
            linkedPortal.isActive = false;
            TeleportObject(other.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isActive = true;
    }

    public void TeleportObject(Transform objectTransform)
    {
        // set the player's position and rotation to the other portal's
        objectTransform.SetPositionAndRotation(linkedPortal.spawnPoint.position, linkedPortal.transform.rotation);

        // Store Y rotation from portal
        float yRot = objectTransform.eulerAngles.y;

        // set new rotation to teleported object
        objectTransform.eulerAngles = new Vector3(0, yRot, 0);

        // override FPSController's mouse look caching
        if (objectTransform.GetComponent<RigidbodyFirstPersonController>())
        {
            objectTransform.GetComponent<RigidbodyFirstPersonController>().MouseReset();
        }
    }
}