using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance { get; private set; }
    private AudioSource source;

    private void Awake()
    {
        instance = this;
        source = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip _sound)
    {
        source.PlayOneShot(_sound);
    }

    //[SerializeField] Slider volumeSlider;

    //void Start()
    //{
    //    if(!PlayerPrefs.HasKey("musicVolume"))
    //    {
    //        PlayerPrefs.SetFloat("musicVolume", 1);
    //        Load();
    //    }
    //}

    //public void ChangeVolume()
    //{
    //    AudioListener.volume = volumeSlider.value;
    //    Save();
    //}

    //private void Load()
    //{
    //    volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    //}

    //private void Save()
    //{
    //    PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    //}
}
