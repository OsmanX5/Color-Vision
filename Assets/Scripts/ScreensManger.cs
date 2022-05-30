using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreensManger : MonoBehaviour
{
    [Serializable]
    public struct Screen
    {
        public string name;
        public GameObject Object;
    }
    //List contain all the game screens
    public Screen[] screens;
    

    public void ShowScreen(string name)
    {
        foreach (Screen screen in screens)
        {
            if (screen.name == name) screen.Object.SetActive(true); 
            else screen.Object.SetActive(false);
        }
    }
}
