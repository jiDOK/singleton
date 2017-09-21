using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{

    public AudioClip[] clips;
    public int startClipIndex;

    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        source.playOnAwake = false;
        source.loop = true;
        source.clip = clips[startClipIndex];
        source.Play();
    }

}
