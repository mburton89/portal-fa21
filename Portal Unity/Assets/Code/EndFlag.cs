using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFlag : MonoBehaviour
{
    public Vector3 roateDirection;
    public float rotateSpeed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print("You Win!");
            WinMenu.Instance.ShowWinMenu();
        }
    }

    void Update()
    {
        transform.Rotate(roateDirection * rotateSpeed);
    }
}
