using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreensManger : MonoBehaviour
{
    // Script name : ScreensManger
    // Script task : Control in showing screens
    // Attatch to  : Attatch to Game manger

    [SerializeField] GameObject ScreensHolder; //The game object contains all screen
    List<GameObject> screens = new List<GameObject>(); //List contain all the game screens

    private void Awake()
    {
        //Assign screens to the list
        for(int i=0;i< ScreensHolder.transform.childCount; i++)
        {
            screens.Add(ScreensHolder.transform.GetChild(i).gameObject);
        }
    }
    public void ShowScreen(string name)
    {
        // Function task : Activate the screen "name" and disactive the other 
        // Function calling: when a button pressed in Main menue screen
        foreach (GameObject screen in screens)
        {
            if (screen.name == name) screen.SetActive(true); 
            else screen.SetActive(false);
        }
    }
}
