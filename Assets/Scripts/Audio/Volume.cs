using UnityEngine;
using UnityEngine.Audio;

public class Volume : ZeltBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume(float Volume)
    {
        audioMixer.SetFloat("Volume", Volume);
    }

}
