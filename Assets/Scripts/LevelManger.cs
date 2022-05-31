using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManger : MonoBehaviour
{
    public static List<Vector2> levels = new List<Vector2>() {
        new Vector2(1f,0.3f),
        new Vector2(0.29f,0.15f),
        new Vector2(0.14f,0.051f),
        new Vector2(0.05f,0.01f)
    };
    public static int getTheLevel(float precent)
    {
        for (int i = 0; i < 4; i++)
        {
            if (levels[i].x <= precent && precent <= levels[i].y) return i + 1;
        }
        return 1;
    }
    public static void UpdatePlayerLevel(){
        Player.Level = getTheLevel(Player.maxDiffrance);
    }
}
