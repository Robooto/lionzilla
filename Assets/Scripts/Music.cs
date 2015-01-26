using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {

    private static Music instance = null;

    public static Music Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            if (instance.audio.clip != audio.clip)
            {
                instance.audio.clip = audio.clip;
                instance.audio.volume = audio.volume;
                instance.audio.Play();
            }

            Destroy(this.gameObject);
            return;
        }
        instance = this;
        audio.Play();
        DontDestroyOnLoad(this.gameObject);
    }
}