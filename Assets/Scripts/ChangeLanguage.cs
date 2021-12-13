using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.EventSystems;

public class ChangeLanguage : MonoBehaviour
{

    int index = 0;
    public GameObject selected;
    public AudioSource sfx;
    public LocalizationSettings language;

    private void Start()
    {
        index = PlayerPrefs.GetInt("current_language");
    }
    public void NoSaving()
    {
        language.SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[PlayerPrefs.GetInt("current_language")]);
        index = PlayerPrefs.GetInt("current_language");
    }

    public void Saving()
    {
        language.SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[index]);
        PlayerPrefs.SetInt("current_language", index);
        PlayerPrefs.Save();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            NoSaving();
        }

        selected = EventSystem.current.currentSelectedGameObject;

        if (selected.name == "ButtonLanguage")
        {
            if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
            {
                sfx.Play();
            }

            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                index++;
                if (index > 2)
                {
                    index = 0;
                }
                LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
            }

            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                index--;
                if (index < 0)
                {
                    index = 2;
                }
                LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
            }
        }
        
    }
}
