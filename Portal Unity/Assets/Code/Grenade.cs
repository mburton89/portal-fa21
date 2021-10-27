using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float explosionForce = 10f;
    public float radius = 10f;
    //Rigidbody rigidbody;
    public float delay;
    public GameObject explosionEffect;

    // Start is called before the first frame update
    void Start()
    {
       // rigidbody = GetComponent<Rigidbody>();
        Invoke("Explode", delay);
    }

    // Update is called once per frame
    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider collider in colliders)
        {
            Rigidbody colliderRB = collider.GetComponent<Rigidbody>();

            if (colliderRB != null)
            {
                colliderRB.AddExplosionForce(explosionForce, transform.position, radius, 1f, ForceMode.Impulse);
            }
        }
        Destroy(gameObject);
        Instantiate(explosionEffect, transform.position, transform.rotation);
    }
}
