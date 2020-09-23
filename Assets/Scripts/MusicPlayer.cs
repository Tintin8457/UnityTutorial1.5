using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    //Get music clips and sound source
    public AudioClip soundOne;
    public AudioClip soundTwo;
    public AudioSource soundSource;

    // Update is called once per frame
    void Update()
    {
        //Press W to play the first audio clip
        if (Input.GetKeyDown(KeyCode.W))
        {
            soundSource.clip = soundOne;
            soundSource.Play();
        }

        //Release W to stop playing the first audio clip
        if (Input.GetKeyUp(KeyCode.W))
        {
            soundSource.Stop();
        }

        //Press R to play the second audio clip
        if (Input.GetKeyDown(KeyCode.R))
        {
            soundSource.clip = soundTwo;
            soundSource.Play();
        }

        //Release R to stop playing the second audio clip
        if (Input.GetKeyUp(KeyCode.R))
        {
            soundSource.Stop();
        }

        //Press L to repeatedly play the audio clip 
        if (Input.GetKeyDown(KeyCode.L))
        {
            soundSource.loop = true;
        }
        
        //Release L to stop repeatedly playing the audio clip 
        if (Input.GetKeyUp(KeyCode.L))
        {
            soundSource.loop = false;
        }

        //Press V to lower the volume of the sound
        if (Input.GetKeyDown(KeyCode.V))
        {
            soundSource.volume = 0.5f;
        }
        
        //Release V to increase the volume of the sound
        if (Input.GetKeyUp(KeyCode.V))
        {
            soundSource.volume = 1.0f;
        }
    }
}
