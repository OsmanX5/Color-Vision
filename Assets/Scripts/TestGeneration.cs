using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TestGeneration : MonoBehaviour
{
    // Script name : Test generation
    // Script task : Generate test
    // Attatch to  : Attatch to Game manger

    [SerializeField] GameObject testObject;   //Refrance for the game object contains all squars test
    [SerializeField] TMP_Text text;           //Refrance for the Text that show the diffrance
    GameObject[] testSquars;                  // Array contains all test squars  
    public float PrecntageDiffrance= 0.8f;           // float show the precentage diffrance
    
    void Start()
    {
        GenerateTest(Color.red, PrecntageDiffrance);
    }

    // The function that generate the Test have 2 inputs 
    //      original : the color of the test squars
    //      precentageDiffrance : the precentage diffrance of the diffrent color
    public void GenerateTest(Color original,float precentageDiffrance)
    {
        // 1- show the precentageDiffrance in the TMP text
        text.text = (PrecntageDiffrance * 100).ToString("0");
        // 2- Generate an empty array of 25 game object
        testSquars = new GameObject[25];
        // 3- Assign the squars of the [testObject] to Array and set thier color to original
        for (int i = 0; i < 25; i++)
        {
            testSquars[i] = testObject.transform.GetChild(i).transform.GetChild(0).gameObject;
            testSquars[i].GetComponent<Image>().color = original;
            testSquars[i].GetComponent<TestcolorSquare>().correct = false;
        }
        // 4- Generate a random number which will be the diffrance color number
        int rand = Random.Range(0,24);
        // 5- Assign the diffrent color which will be diffrent with precentageDiffrance and make the
        Color diffrent = original * (1 -precentageDiffrance);
        testSquars[rand].GetComponent<Image>().color = diffrent;
        testSquars[rand].GetComponent<TestcolorSquare>().correct = true;
    }
}
