using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using StarterAssets;
using UnityStandardAssets;

public class Portal : MonoBehaviour
{
    public Transform linkedPortal;

    private void OnTriggerEnter(Collider other)
    {
        TeleportObject(other.transform);
    }

    void TeleportObject(Transform objectTransform)
    {
        //objectTransform.SetPositionAndRotation(linkedPortal.transform.position, linkedPortal.transform.rotation);
        //objectTransform.position = linkedPortal.position;
        objectTransform.position = Vector3.zero;
        print("hi");
    }

	void TeleportObjects(Transform objectTransform)
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

	}
}
