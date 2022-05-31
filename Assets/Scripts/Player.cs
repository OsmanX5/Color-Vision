using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string ID = SystemInfo.deviceUniqueIdentifier;
    public int Level = 1;
    public float maxDiffrance = 100;
    
    List<Vector2> levels = new List<Vector2>() {
        new Vector2(1f,0.3f),
        new Vector2(0.29f,0.15f),
        new Vector2(0.14f,0.051f),
        new Vector2(0.05f,0.01f)
    };

    void UpdateTheLevel()
    {
        for(int i = 0; i < 4; i++)
        {
            if (levels[i].x <= maxDiffrance && maxDiffrance <= levels[i].y)
                Level = i + 1;
        }
    }

}
