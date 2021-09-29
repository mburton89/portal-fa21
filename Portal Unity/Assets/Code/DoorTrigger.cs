using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Door linkedDoor;

    private void OnTriggerEnter(Collider other)
    {
        linkedDoor.Open();
    }

    private void OnTriggerStay(Collider other)
    {
        linkedDoor.Open();
    }

    private void OnTriggerExit(Collider other)
    {
        linkedDoor.Close();
    }
}
