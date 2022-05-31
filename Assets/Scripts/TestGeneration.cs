using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TestGeneration : MonoBehaviour
{
    public int[][] arr = new int[5][];
    public GameObject testObject;
    public float PrecntageDiffrance= 0.8f;
    public TMP_Text text;
    GameObject[] testSquars;
    void Start()
    {
        GenerateTest(Color.red, PrecntageDiffrance);
    }
    
    public void GenerateTest(Color original,float precentageDiffrance)
    {
        text.text = (PrecntageDiffrance * 100).ToString("0");
        testSquars = new GameObject[25];
        for (int i = 0; i < 25; i++)
        {
            testSquars[i] = testObject.transform.GetChild(i).transform.GetChild(0).gameObject;
            testSquars[i].GetComponent<Image>().color = original;
            testSquars[i].GetComponent<TestcolorSquare>().diffrance = false;
        }
        int rand = Random.Range(0,24);
        Color diffrent = original * (1 -precentageDiffrance);
        testSquars[rand].GetComponent<Image>().color = diffrent;
        Debug.Log(testSquars[rand].name);
        testSquars[rand].GetComponent<TestcolorSquare>().diffrance = true;
    }
}
