using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumenSystem : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider ambienteSlider;
    [SerializeField] Slider sfxSlider;
    [SerializeField] Slider masterSlider;

    const string MIXER_MUSIC = "MusicVolume";
    const string MIXER_SFX = "SFXVolume";
    const string MIXER_MASTER = "MasterVolume";

    private void Awake()
    {
        ambienteSlider.onValueChanged.AddListener(SetMusicVolume);
        sfxSlider.onValueChanged.AddListener(SetSFXVolume);
        masterSlider.onValueChanged.AddListener(SetMasterVolume);
    }

    void SetMusicVolume(float value)
    {
        mixer.SetFloat(MIXER_MUSIC, Mathf.Log10(value) * 20);
    }

    void SetSFXVolume(float value)
    {
        mixer.SetFloat(MIXER_SFX, Mathf.Log10(value) * 20);
    }

    void SetMasterVolume(float value)
    {
        mixer.SetFloat(MIXER_MASTER, Mathf.Log10(value) * 20);
    }
}
