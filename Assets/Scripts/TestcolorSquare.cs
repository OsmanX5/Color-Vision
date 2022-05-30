using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestcolorSquare : MonoBehaviour
{
    public bool diffrance = false;
    GameObject manger;
    TestGeneration testManger;
    private void Awake()
    {
        manger = GameObject.Find("GameManger");
        testManger = manger.GetComponent<TestGeneration>();
    }
    public void Reload()
    {
        
        if (diffrance)
        {
            Color original = new Color(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f));
            if(testManger.PrecntageDiffrance>0.01f)
            testManger.PrecntageDiffrance *= 0.5f;
            
            testManger.GenerateTest(original, testManger.PrecntageDiffrance);
        }
    }
}
