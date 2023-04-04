using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimeControl : MonoBehaviour
{
    public int time = 60;
    public GameObject playerModel;
    public GameObject player;
    public GameObject levelControl;
    public GameObject timeDisplay;

    void Start()
    {
        StartCoroutine(Timer());
    }

   
    IEnumerator Timer()
    {
        while (time > 0)
        {
            time--;
            timeDisplay.GetComponent<TextMeshProUGUI>().text = time.ToString();
            yield return new WaitForSeconds(1);
        }

        playerModel.SetActive(false);
        player.GetComponent<PlayerMove>().enabled = false;
        PlayerMove.canMove = false;
        levelControl.GetComponent<EndRunSequence>().enabled = true;
        levelControl.GetComponent<LevelDistance>().enabled = false;

    }
}
