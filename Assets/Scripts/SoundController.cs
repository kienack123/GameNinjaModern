using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    // Singleton
    public static SoundController instance { get; private set; }
    private void Awake()
    {
        instance = this;
    }

    public void PlayThisSound(string clipName , float volumeMutiplier)
    {
        AudioSource audioSource = this.gameObject.AddComponent<AudioSource>();

        audioSource.volume *= volumeMutiplier;

        audioSource.PlayOneShot((AudioClip)Resources.Load("Sounds/" + clipName, typeof(AudioClip)));

        
    }
}
