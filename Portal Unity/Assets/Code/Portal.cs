using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Portal : MonoBehaviour
{
    public Portal linkedPortal;
    public bool isActive;

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
        //1. Set the player's position AND rotation to the other portal's
        objectTransform.SetPositionAndRotation(linkedPortal.transform.position, linkedPortal.transform.rotation);

        //2. Store player's current Y rotation 
        float yRot = objectTransform.eulerAngles.y;

        //3. Set new rotation
        objectTransform.eulerAngles = new Vector3(0, yRot, 0);

        //4. Override FPS controller mouse cache
        if (objectTransform.GetComponent<RigidbodyFirstPersonController>())
        {
            objectTransform.GetComponent<RigidbodyFirstPersonController>().MouseReset();
        }
    }
}
