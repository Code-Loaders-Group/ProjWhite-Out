using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip swordSwing, fireBall;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        swordSwing = Resources.Load<AudioClip>("swordSwing");
        fireBall = Resources.Load<AudioClip>("fireBall");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "swordSwing":
                audioSrc.PlayOneShot(swordSwing);
                break;
            case "fireBall":
                audioSrc.PlayOneShot(fireBall);
                break;
        }
    }
}
