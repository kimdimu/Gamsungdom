using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : MonoBehaviour
{
    public AudioClip SFX;
    private AudioSource music;

    public static SoundFX instance;

    private void Awake()
    {
        if (SoundFX.instance == null)
            SoundFX.instance = this;
    }
    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    public void playSound()
    {
        music.PlayOneShot(SFX);
    }

}
