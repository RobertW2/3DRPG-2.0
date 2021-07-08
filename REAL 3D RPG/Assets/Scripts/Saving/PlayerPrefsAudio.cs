using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class PlayerPrefsAudio : MonoBehaviour
{
    public Slider SoundEffects;
    public Slider Music;

    void Start()
    {

        SoundEffects.value = PlayerPrefs.GetFloat("OptionScore");
        Music.value = PlayerPrefs.GetFloat("OptionLives");
    }

    void Update()
    {
        PlayerPrefs.SetFloat("OptionScore", SoundEffects.value);
        PlayerPrefs.SetFloat("OptionLives", Music.value);

    }

    public void AdjustMusicVolume(float value)
    {
        FindObjectOfType<MusicAudio>().GetComponent<AudioSource>().volume = value;
    }


}
