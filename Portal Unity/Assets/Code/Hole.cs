using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{

    public GameObject goop;
    bool sealant = true;
    public Rigidbody Prefab;
    public Transform Spawnpoint;
    public Rigidbody RigidPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (RigidPrefab != null)
        {
            sealant = false;
        }
    }

    public void Iftouched()
    {
        if (true)
        {

        }




    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<GameObject>())
        {
            sealant = true;
        }
        if (sealant == true)
        {
         
            RigidPrefab = Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation) as Rigidbody;
        }

    }


}

