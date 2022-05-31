using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestcolorSquare : MonoBehaviour
{
    // Script name : TestcolorSquare
    // Script task : Contorl in the squars test objects
    // Attatch to  : Attatch to square test prefab

   
    public bool correct = false; // A boolean show that is this the correct box or not
    GameObject manger;           // Refrance to game manger
    TestGeneration testManger;   // Refrance to Test generation    
    private void Awake()
    {
        manger = GameObject.Find("GameManger");            //Assign Manger by searching of it name
        testManger = manger.GetComponent<TestGeneration>();//Assign Test Manger
    }
    public void ReGenerateTheTest()
    {
        // Function task   : 1- Regenerate the test if the player tap the correct square
        //                   2- End the test and update player level if tap the incorrect square
        // Function calling: called when the player tabing the square from the button event
        if (correct)
        {
            // 1- Generate a Random color
            Color original = new Color(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f));
            // 2- decreace the diffrance by 5% if it is bigger than 1%
            if(testManger.PrecntageDiffrance>0.01f)testManger.PrecntageDiffrance *= 0.95f;
            // 3 - Re generate the test
            testManger.GenerateTest(original, testManger.PrecntageDiffrance);
        }
        else
        {
            TestEnd();
        }
    }
    void TestEnd()
    {

    }
}
