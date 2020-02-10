using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManageer : MonoBehaviour
{
    public static AudioClip CarCrash, YouWon;
    private static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        CarCrash = Resources.Load<AudioClip>("CarCrash");
        YouWon = Resources.Load<AudioClip>("YouWon");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "CarCrash":
                audioSrc.PlayOneShot(CarCrash);
                break;
            case "YouWon":
                audioSrc.PlayOneShot(YouWon);
                break;
        }
    }
}
