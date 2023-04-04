using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countRun;
    public GameObject fadeIn;
    public AudioSource runFX;
    public AudioSource readyFx;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1);
        countDown3.SetActive(true);
        readyFx.Play();
        yield return new WaitForSeconds(1);
        countDown2.SetActive(true);
        readyFx.Play();
        yield return new WaitForSeconds(1);
        countDown1.SetActive(true);
        readyFx.Play();
        yield return new WaitForSeconds(1);
        countRun.SetActive(true);
        runFX.Play();

        PlayerMove.canMove = true;
    }
}
