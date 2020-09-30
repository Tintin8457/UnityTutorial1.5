using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Regardless of the script name, the script controls both the dog animations and game sounds
public class MusicPlayer : MonoBehaviour
{
    //Get music clips and sound source
    public AudioClip soundOne;
    public AudioClip soundTwo;
    public AudioSource soundSource;

    Animator dogAnim; //Get dog animations
    public Text nameText; //Get text to display name

    void Start()
    {
        dogAnim = GetComponent<Animator>(); //Access the animator of the dog
        nameText.text = ""; //Default should be blank
    }

    // Update is called once per frame
    void Update()
    {
        //Press W to play the first audio clip and make the dog walk
        if (Input.GetKeyDown(KeyCode.W))
        {
            soundSource.clip = soundOne;
            soundSource.Play();
            dogAnim.SetInteger("State", 1); //The dog will walk
            nameText.text = "The dog has moved. This game is created by Brandon Perez."; //Display name
        }

        //Release W to stop playing the first audio clip and have the dog stop walking
        if (Input.GetKeyUp(KeyCode.W))
        {
            soundSource.Stop();
            dogAnim.SetInteger("State", 0); //The dog will idle and stop walking
            nameText.text = ""; //Text goes blank
        }

        //Press R to play the second audio clip and make the dog run
        if (Input.GetKeyDown(KeyCode.R))
        {
            soundSource.clip = soundTwo;
            soundSource.Play();
            dogAnim.SetInteger("State", 2); //The dog will run
            nameText.text = "The dog has moved. This game is created by Brandon Perez."; //Display name
        }

        //Release R to stop playing the second audio clip and have the dog stop running
        if (Input.GetKeyUp(KeyCode.R))
        {
            soundSource.Stop();
            dogAnim.SetInteger("State", 0); //The dog will idle and stop running
            nameText.text = ""; //Text goes blank
        }

        //Press L to repeatedly play the audio clip 
        if (Input.GetKeyDown(KeyCode.L))
        {
            soundSource.loop = true;
            nameText.text = "The music is now looping. This game is created by Brandon Perez."; //Display name
        }
        
        //Release L to stop repeatedly playing the audio clip 
        if (Input.GetKeyUp(KeyCode.L))
        {
            soundSource.loop = false;
            nameText.text = ""; //Text goes blank
        }

        //Press V to lower the volume of the sound
        if (Input.GetKeyDown(KeyCode.V))
        {
            soundSource.volume = 0.5f;
            nameText.text = "The music volume has changed. This game is created by Brandon Perez."; //Display name
        }
        
        //Release V to increase the volume of the sound
        if (Input.GetKeyUp(KeyCode.V))
        {
            soundSource.volume = 1.0f;
            nameText.text = ""; //Text goes blank
        }

        //Press M to mute the volume of the sound
        if (Input.GetKeyDown(KeyCode.M))
        {
            soundSource.mute = true;
            nameText.text = "The music volume is muted. This game is created by Brandon Perez."; //Display name
        }

        //Release M to unmute the volume of the sound
        if (Input.GetKeyUp(KeyCode.M))
        {
            soundSource.mute = false;
            nameText.text = ""; //Text goes blank
        }

        //Quit the game
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
