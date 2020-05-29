using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioVisable : MonoBehaviour
{
    public static AudioVisable Instance;
    private void Awake()
    {
        Instance = this;
    }
    AudioSource audioSource;
    public float[] samples = new float[512];

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        GetSpectrumAduioSource();

    }

    void GetSpectrumAduioSource()
    {
        audioSource.GetSpectrumData(samples, 0, FFTWindow.Blackman);
    }

}
