using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas2Script : MonoBehaviour
{

    public AudioSource m_theme2;
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public Animation anim1;
    public Animation anim2;
    private float timer;

    void OnEnable()
    {
        m_theme2.Play();
        timer = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 20)
        {
            ChangeCanvasTo2();
        }

        if (Input.anyKeyDown)
        {
            ChangeCanvasTo3();
        }
    }

    public void ChangeCanvasTo2()
    {
        canvas2.SetActive(false);
        canvas1.SetActive(true);
    }

    public void ChangeCanvasTo3()
    {
        canvas2.SetActive(false);
        canvas3.SetActive(true);
    }
}
