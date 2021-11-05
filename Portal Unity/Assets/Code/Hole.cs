using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public GameObject sealedHole;
  
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GOOP"))
        {
            sealedHole.SetActive(true);
            Destroy(other.gameObject);
        }
    }
}

