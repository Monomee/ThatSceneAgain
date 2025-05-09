using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] Slider sliderMusic;
    [SerializeField] AudioMixer myAudioMixer;
    public AudioSource backgroundMusic;
    public AudioSource endMusic;

    public static AudioManager Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;            
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
        if(sliderMusic == null) sliderMusic = GameObject.FindGameObjectWithTag("Music").GetComponent<Slider>();
    }
    private void Start()
    {
        SetVolumeMusic();
        backgroundMusic = this.GetComponents<AudioSource>()[0];
        endMusic = this.GetComponents<AudioSource>()[1];
    }
    public void SetVolumeMusic()
    {
        if(sliderMusic != null)
        {
            float volume = sliderMusic.value;
            myAudioMixer.SetFloat("Master", Mathf.Log10(volume)*20);
        }
    }
}
