using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsPreferences : MonoBehaviour
{

    public Slider musicSlider;
    public Slider sfxSlider;
    public Button selection;
    public Button selection_2;
    public GameObject canvas3;
    public GameObject canvas6;
    public AudioSource cancel;

    void OnEnable()
    {
        selection.Select();
    }

    private void Start()
    {
        sfxSlider.value = PlayerPrefs.GetFloat("sfxVolume", 1.0f);
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume", 1.0f);
    }

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            cancel.Play();
            NoSaving();
            ChangeScreen();
        }
    }

    public void ChangeScreen()
    {
        canvas6.SetActive(false);
        canvas3.SetActive(true);
    }

    public void NoSaving()
    {
        sfxSlider.value = PlayerPrefs.GetFloat("sfxVolume", 1.0f);
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume", 1.0f);
    }

    public void Saving()
    {
        PlayerPrefs.SetFloat("musicVolume", musicSlider.value);
        PlayerPrefs.SetFloat("sfxVolume", sfxSlider.value);
        PlayerPrefs.Save();
    }
}
