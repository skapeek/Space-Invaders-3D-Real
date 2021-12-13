using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Slider sfx;
    public Slider music;

    void Start()
    {
        sfx.value = PlayerPrefs.GetFloat("sfxVolume");
        music.value = PlayerPrefs.GetFloat("musicVolume");
    }

}
