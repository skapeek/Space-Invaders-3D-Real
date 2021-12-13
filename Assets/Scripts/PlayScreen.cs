using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayScreen : MonoBehaviour
{
    public Button selected;
    public GameObject canvas7;
    public GameObject canvas4;
    public GameObject canvas3;
    public AudioSource maintheme;
    public AudioSource singleplayer;
    public AudioSource coop;
    public AudioSource online;

    void OnEnable()
    {
        selected.Select();
        maintheme.Stop();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            canvas4.SetActive(false);
            canvas3.SetActive(true);
            singleplayer.Stop();
            coop.Stop();
            online.Stop();
            maintheme.Play();
        }
    }
    
    public void changeCanvasSP()
    {
        canvas7.SetActive(true);
        canvas4.SetActive(false);
    }
}

