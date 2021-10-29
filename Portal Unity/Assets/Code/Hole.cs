using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{

    public GameObject goop;
    bool sealant;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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

        }

    }


}

