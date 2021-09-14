using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

[Serializable]
public class AudioData
{
    public AudioClip[] clips;


    public AudioData(AudioClip[] defaultClips = null)
    {
        clips = defaultClips;
    }
}

[CreateAssetMenu(fileName = "Loclized Audio", menuName = "Localization/Data/Audio")]
public class AudioLocalizationData : ScriptableObject
{
    public AudioData english = new AudioData();
    public AudioData portuguese = new AudioData();
    public AudioData japanese = new AudioData();
}
