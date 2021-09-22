using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMenu : MonoBehaviour
{
    public static WinMenu Instance;
    public GameObject WinMenuContainer;

    void Start()
    {
        Instance = this;
    }

    public void ShowWinMenu()
    {
        WinMenuContainer.SetActive(true);
    }

}