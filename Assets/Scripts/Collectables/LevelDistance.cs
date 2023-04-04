using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class LevelDistance : MonoBehaviour
{
    public GameObject distanceDisplay;
    public int distanceRan;
    public bool addingDistance = false;

    // Update is called once per frame
    void Update()
    {
        if (addingDistance == false)
        {

            addingDistance = true;
            StartCoroutine(AddingDistance());
        }
    }


    IEnumerator AddingDistance()
    {
        distanceRan += 1;
        distanceDisplay.GetComponent<TextMeshProUGUI>().text = distanceRan.ToString();
        yield return new WaitForSeconds(0.25f);
        addingDistance = false;
    }

}
