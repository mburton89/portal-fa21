using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sealantbum : MonoBehaviour
{


    public KeyCode launchKey;
    public KeyCode bitchasswhore;
    public Transform firePoint;
    public GameObject testPrefab;
    GameObject goop;
    float speed = 1;
    float maxScale = 0;
    public bool button;
    public Vector3 bitch;
    public float scaleRate = 1.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (button == true & Input.GetKeyDown(launchKey))
        {

            spawn();

        }


        if (Input.GetKey(launchKey))
        {
            Grow();
            print("fatassbitch");
        }
        if (Input.GetKey(bitchasswhore))
        {
            destoryGOD();

        }


        //if (goop.transform.localScale.x > minScale)
        //{

        //}
        //else if (transform.localScale.x > maxScale)
        //{
        //    scaleRate = -Mathf.Abs(scaleRate);
        //}
        //ApplyScaleRate();

    }


    public void spawn()
    {



        if (button)
        {
            goop = Instantiate(testPrefab, new Vector3(firePoint.position.x + 2, firePoint.position.y + 2, firePoint.position.z + 2), Quaternion.identity) as GameObject;
            goop.transform.parent = testPrefab.transform;
            button = false;
        }


        //goop.transform.localScale += Vector3.one * scaleRate;
    }

    void Grow()
    {
        if (goop.transform.localScale.x < 5)

        {
            goop.transform.localScale += Vector3.one * scaleRate;
        }
        else
        {
            button = false;
        }
        print(goop.transform.localScale.x);
    }

    public void destoryGOD()
    {
        RaycastHit raycastHit;

        if (Physics.Raycast(firePoint.position, transform.TransformDirection(Vector3.forward), out raycastHit, Mathf.Infinity) && raycastHit.collider.gameObject.tag == "GOOP")
        {

            Destroy(goop);
            button = true;

        }


    }



}