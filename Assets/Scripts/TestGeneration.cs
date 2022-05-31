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

    [SerializeField] GameObject testObject;           //Refrance for the game object contains all squars test
    [SerializeField] TMP_Text PrecentageText;                   //Refrance for the Text that show the diffrance
    [SerializeField] TMP_Text correctsText;                   //Refrance for the Text that show the diffrance
    GameObject[] testSquars;                          // Array contains all test squars  
    public float PrecntageDiffrance;                  // float show the precentage diffrance
    List<float> startingDiffrance = new List<float>();// Precentage diffrance start foreach level
    int correct = -1; //number of correct boxes in each level
    private void Awake()
    {
        for(int i=0;i<4; i++)
        {
            startingDiffrance.Add(LevelManger.levels[i].x);
        }
    }
    void Start()
    {
        PrecntageDiffrance = startingDiffrance[Player.Level-1];
        GenerateTest(Color.red, PrecntageDiffrance);
    }

    // The function that generate the Test have 2 inputs 
    //      original : the color of the test squars
    //      precentageDiffrance : the precentage diffrance of the diffrent color
    public void GenerateTest(Color original,float precentageDiffrance)
    {
        
        // 1- show the precentageDiffrance and corrects in the TMP text
        PrecentageText.text = (PrecntageDiffrance * 100).ToString("0");
        correct += 1;
        correctsText.text = correct.ToString();
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
