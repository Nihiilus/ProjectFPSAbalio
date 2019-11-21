using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour
{

    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider col)
    {
		if (col.transform.tag == "Player")
		{
			if (!alreadyPlayed)
			{
				audio.PlayOneShot(SoundToPlay, Volume);
				alreadyPlayed = true;
			}
		}
    }
}