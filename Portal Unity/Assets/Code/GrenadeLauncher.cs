using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeLauncher : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject grenadePrefab;
    public float range = 15f;
    public KeyCode launchKey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(launchKey))
        {
            LaunchGrenade();
        }
    }

    void LaunchGrenade()
    {
        GameObject newGrenade = Instantiate(grenadePrefab, spawnPoint.position, spawnPoint.rotation);
        newGrenade.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * range, ForceMode.Impulse);
    }
}
