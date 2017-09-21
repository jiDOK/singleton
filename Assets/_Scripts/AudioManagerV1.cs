using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManagerV1 : MonoBehaviour
{

    public static AudioManagerV1 instance { get; private set; }

    public AudioClip[] clips;
    public int startClipIndex;

    AudioSource source;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        source = GetComponent<AudioSource>();
        source.playOnAwake = false;
        source.loop = true;
        source.clip = clips[startClipIndex];
        source.Play();
    }

}
