using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFlag : MonoBehaviour
{
    public Vector3 rotateDirection;
    public float rotateSpeed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            WinMenu.Instance.ShowWinMenu();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateDirection * rotateSpeed);
    }
}
