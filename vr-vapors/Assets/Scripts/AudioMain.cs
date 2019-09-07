using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioMain : MonoBehaviour
{
    AudioSource audioSource;
    public static float[] audioSamples = new float[512];

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();
    }

    /// <summary>
    /// Listens to audio source, gets samples and places them into each element of audioSamples
    /// </summary>
    void GetSpectrumAudioSource() {
        audioSource.GetSpectrumData(audioSamples, 0, FFTWindow.Blackman); 
    }
}
