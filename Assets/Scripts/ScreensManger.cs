using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreensManger : MonoBehaviour
{
    // Refrance for UI Screens
    public GameObject MainMenu;
    public GameObject Test;


    //List contain all the game screens
    List<GameObject> screens;
    private void Start()
    {
        screens = new List<GameObject>();
        if (MainMenu!=null) screens.Add(MainMenu);
        if (Test != null) screens.Add(Test);

    }

    public void ShowScreen(string name)
    {
        foreach (GameObject screen in screens)
        {
            if (screen.name == name) screen.SetActive(true); 
            else screen.SetActive(false);
        }
    }
}
