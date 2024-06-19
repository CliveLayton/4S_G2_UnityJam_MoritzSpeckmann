using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager Instance { get; private set; }

    [Header("Audio Sources")]
    [SerializeField] private AudioSource musicAudio;
    [SerializeField] private AudioSource sFXAudio;

    [Header("AudioClips")] 
    [SerializeField] private AudioClip mainMenuMusic;
    [SerializeField] private AudioClip buttonSound;
    [SerializeField] private AudioClip playGameSound;
    

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        musicAudio.clip = mainMenuMusic;
        musicAudio.Play();
    }

    public void PlaySFXSound(AudioClip clip)
    {
        sFXAudio.PlayOneShot(clip);
    }

    public void PlayButtonSound()
    {
        sFXAudio.PlayOneShot(playGameSound);
    }
}
