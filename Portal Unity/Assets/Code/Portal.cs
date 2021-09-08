using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    //void TeleportObject(Transform objectTransform)
    //{
    //    print(objectTransform.gameObject.name);
    //    objectTransform.position = Vector3.zero;
    //    //objectTransform.position = linkedPortal.transform.position;
    //}

    void TeleportObject(Transform objectTransform)
    {
        // cache player rotation to revert after teleport
        float xRot = objectTransform.rotation.x;
        float zRot = objectTransform.rotation.z;

        // set the player's position and rotation to the other portal's
        //TODO Actually teleport the player...
        //objectTransform.position = linkedPortal.transform.position;
        objectTransform.SetPositionAndRotation(linkedPortal.transform.position, linkedPortal.transform.rotation);

        // Y rotation from portal
        float yRot = objectTransform.eulerAngles.y;

        // combine previously cached axes with new Y to get new rotation. Prevents flipping upside-down
        objectTransform.eulerAngles = new Vector3(xRot, yRot, zRot);

        // override FPSController's mouse look caching
        if (objectTransform.GetComponent<RigidbodyFirstPersonController>())
        {
            objectTransform.GetComponent<RigidbodyFirstPersonController>().MouseReset();
        }
    }
}
