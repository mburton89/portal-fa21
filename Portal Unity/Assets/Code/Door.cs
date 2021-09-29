using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float maxYPosition;
    public float minYPosition;
    public float openSpeed;
    public bool shouldOpen = false;

    public void Open()
    {
        shouldOpen = true;
    }

    public void Close()
    {
        shouldOpen = false;
    }

    private void Update()
    {
        if (shouldOpen && transform.localPosition.y < maxYPosition)
        {
            transform.Translate(Vector3.up * Time.deltaTime * openSpeed, Space.World);
        }
        else if(!shouldOpen && transform.localPosition.y > minYPosition)
        {
            transform.Translate(Vector3.down * Time.deltaTime * openSpeed, Space.World);
        }
    }
}
