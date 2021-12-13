using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroSkip : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public GameObject canvas4;
    public GameObject canvas5;
    public GameObject canvas6;
    public GameObject canvas7;
    private float timer;
    public AudioSource m_theme1;
    public AudioSource m_theme2;

    private void Awake()
    {
        canvas2.SetActive(false);
        canvas3.SetActive(false);
        canvas4.SetActive(false);
        canvas5.SetActive(false);
        canvas6.SetActive(false);
        canvas7.SetActive(false);

    }

    private void OnEnable()
    {
        m_theme1.Play();
        m_theme2.Stop();
        timer = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space)||timer >= 40)
        {
            ChangeCanvas();
        }
    }

    public void ChangeCanvas()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(true);
        m_theme1.Stop();
    }
}
