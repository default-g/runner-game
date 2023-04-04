using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CollectableControl : MonoBehaviour
{
    public static int score = 0;
    public GameObject scoreDisplay;
    public GameObject coinEndDisplay;
   
    // Update is called once per frame
    void Update()
    {
        if (scoreDisplay != null)
        {
            scoreDisplay.GetComponent<TextMeshProUGUI>().text = score.ToString();
            coinEndDisplay.GetComponent<TextMeshProUGUI>().text = score.ToString();
        }
    }
}